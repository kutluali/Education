using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebUI.DTOs.LoginDtos;
using WebUI.DTOs.UserDtos;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly HttpClient _client;

        //named client 

        public LoginController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginDto userLoginDto)
        {
            var result = await _client.PostAsJsonAsync("users/login", userLoginDto);
            if (!result.IsSuccessStatusCode)
            {
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
                return View(userLoginDto);
            }

            var handler = new JwtSecurityTokenHandler();
            var response = await result.Content.ReadFromJsonAsync<LoginResponseDto>();
            var token = handler.ReadJwtToken(response.Token);
            var claims = token.Claims.ToList();

            if (response.Token != null)
            {
                claims.Add(new Claim("Token", response.Token));
                var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
                var authProps = new AuthenticationProperties
                {
                    ExpiresUtc = response.ExpireDate,
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);

                //Kullanıcının Rollerini Alıyoruz
                var roles = claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList();


                if (roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Message", new { area = "Admin" });
                }
                else if (roles.Contains("Teacher"))
                {
                    return RedirectToAction("Index", "MyCourse", new { area = "Teacher" });
                }
                else if (roles.Contains("Student"))
                {
                    return RedirectToAction("Index", "CourseRegister", new { area = "Student" });
                }

            }
            ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
            return View(userLoginDto);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
