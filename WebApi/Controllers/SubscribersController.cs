﻿using AutoMapper;
using Business.Abstract;
using DTO.DTOs.SubscriberDtos;
using Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _subscriberService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscriberService.TDelete(id);
            return Ok("Abone Silindi");
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Create(CreateSubscriberDto createSubscriberDto)
        {
            var newValue = _mapper.Map<Subscriber>(createSubscriberDto);
            _subscriberService.TCreate(newValue);
            return Ok("Yeni Abone Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateSubscriberDto updateSubscriberDto)
        {
            var value = _mapper.Map<Subscriber>(updateSubscriberDto);
            _subscriberService.TUpdate(value);
            return Ok("Abone Güncellendi");
        }
    }
}
