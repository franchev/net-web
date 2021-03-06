﻿using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Helpers;
using AutoMapper;

namespace Library.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/authors")]
    public class AuthorsController : Controller
    {
        private ILibraryRepository _libraryRepository;

        public AuthorsController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        [HttpGet("")]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _libraryRepository.GetAuthors();
            // using auto Mapper review the startup.cs
            var authors = Mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo);
           
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(Guid id)
        {
            var authorFromRepo = _libraryRepository.GetAuthor(id);

            if (authorFromRepo == null)
            {
                return NotFound($"author with guid id {id} was not found");
            }
            var author = Mapper.Map<AuthorDto>(authorFromRepo);

            return Ok(author);
        }
    }
}
