﻿using AutoMapper;
using BookLoanApp.Dto.Book;
using BookLoanApp.Models;

namespace BookLoanApp.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper() 
        {
            CreateMap<BookCreationDto, BooksModel>();
            CreateMap<BooksModel, BookEditDto>();
            CreateMap<BookEditDto, BooksModel>();
        }
    }
}
