﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

using Dictionary.Domain.Core;

namespace Dictionary.BLL.DTO
{
    public  class AutomapperConfiguration: Profile, IProfile
    {


        public AutomapperConfiguration()
        : this("MyProfile")
    {
            }
        protected AutomapperConfiguration(string profilename)
            :base(profilename)
        { 
            CreateMap<TranslEngEst, EngEstDTO>()
            .ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
            .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
            .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
            .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
            .ForMember(des => des.EngWord, x => x.MapFrom(src => src.EngWord.Word))
            .ForMember(des => des.EstWord, x => x.MapFrom(src => src.EstWord.Word));//.ReverseMap();

            CreateMap<EngEstDTO, TranslEngEst>()
            .ForMember(des => des.IdTranslation, x => x.MapFrom(src => src.ID))
            .ForPath(des => des.PartOfSpeech.Partname, x => x.MapFrom(src => src.PartOfSpeech))
            .ForPath(des => des.Subcategory.Subcategoryname, x => x.MapFrom(src => src.Subcategory))
            .ForPath(des => des.Subcategory.Category.Categoryname, x => x.MapFrom(src => src.Category))
            .ForPath(des => des.EngWord.Word, x => x.MapFrom(src => src.EngWord))
            .ForPath(des => des.EstWord.Word, x => x.MapFrom(src => src.EstWord));




            CreateMap<TranslEngRus, EngRusDTO>()
            .ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
            .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
            .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
            .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
            .ForMember(des => des.EngWord, x => x.MapFrom(src => src.EngWord.Word))
            .ForMember(des => des.RusWord, x => x.MapFrom(src => src.RusWord.Word));//.ReverseMap();

            CreateMap<EngRusDTO, TranslEngRus>()
            .ForMember(des => des.IdTranslation, x => x.MapFrom(src => src.ID))
            .ForPath(des => des.PartOfSpeech.Partname, x => x.MapFrom(src => src.PartOfSpeech))
            .ForPath(des => des.Subcategory.Subcategoryname, x => x.MapFrom(src => src.Subcategory))
            .ForPath(des => des.Subcategory.Category.Categoryname, x => x.MapFrom(src => src.Category))
            .ForPath(des => des.EngWord.Word, x => x.MapFrom(src => src.EngWord))
            .ForPath(des => des.RusWord.Word, x => x.MapFrom(src => src.RusWord));




            CreateMap<TranslRusEst, RusEstDTO>()
            .ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
            .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
            .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
            .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
            .ForMember(des => des.RusWord, x => x.MapFrom(src => src.RusWord.Word))
            .ForMember(des => des.EstWord, x => x.MapFrom(src => src.EstWord.Word));//.ReverseMap();

            CreateMap<RusEstDTO, TranslRusEst>()
            .ForPath(des => des.IdTranslation, x => x.MapFrom(src => src.ID))
            .ForPath(des => des.PartOfSpeech.Partname, x => x.MapFrom(src => src.PartOfSpeech))
            .ForPath(des => des.Subcategory.Subcategoryname, x => x.MapFrom(src => src.Subcategory))
            .ForPath(des => des.Subcategory.Category.Categoryname, x => x.MapFrom(src => src.Category))
            .ForPath(des => des.RusWord.Word, x => x.MapFrom(src => src.RusWord))
            .ForPath(des => des.EstWord.Word, x => x.MapFrom(src => src.EstWord));
        }


        //public static void Configure()
        //{

        //    //  TranslEngEst one = new TranslEngEst();
        //    // TranslEngRus two = new TranslEngRus();
        //    //TranslRusEst three = new TranslRusEst();

        //    // //v.2
        //    //Mapper.Initialize(cfg => cfg.CreateMap<TranslEngEst, EngEstDTO>()
        //    // .ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
        //    // .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
        //    // .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
        //    // .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
        //    // .ForMember(des => des.EngWord, x => x.MapFrom(src => src.EngWord.Word))
        //    // .ForMember(des => des.EstWord, x => x.MapFrom(src => src.EstWord.Word)).ReverseMap()/*reversemap?*/);



        //    var configEngEst = new MapperConfiguration(cfg => cfg.CreateMap<TranslEngEst, EngEstDTO>()
        //    .ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
        //    .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
        //    .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
        //    .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
        //    .ForMember(des => des.EngWord, x => x.MapFrom(src => src.EngWord.Word))
        //    .ForMember(des => des.EstWord, x => x.MapFrom(src => src.EstWord.Word)));//.ReverseMap()/*reversemap?*/);

        //    //hz reverse mapping
        //    var configEngEstViseVersa = new MapperConfiguration(cfg => cfg.CreateMap<EngEstDTO, TranslEngEst>()
        //    .ForMember(des => des.IdTranslation, x => x.MapFrom(src => src.ID))
        //    .ForMember(des => des.PartOfSpeech.Partname, x => x.MapFrom(src => src.PartOfSpeech))
        //    .ForMember(des => des.Subcategory.Subcategoryname, x => x.MapFrom(src => src.Subcategory))
        //    .ForMember(des => des.Subcategory.Category.Categoryname, x => x.MapFrom(src => src.Category))
        //    .ForMember(des => des.EngWord.Word, x => x.MapFrom(src => src.EngWord))
        //    .ForMember(des => des.EstWord.Word, x => x.MapFrom(src => src.EstWord)));


        //    ///

        //    ////v.2
        //    //Mapper.Initialize(cfg => cfg.CreateMap<TranslEngRus, EngRusDTO>()
        //    //.ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
        //    //.ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
        //    //.ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
        //    //.ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
        //    //.ForMember(des => des.EngWord, x => x.MapFrom(src => src.EngWord.Word))
        //    //.ForMember(des => des.RusWord, x => x.MapFrom(src => src.RusWord.Word)).ReverseMap()/*reversemap?*/);

        //    var configEngRus = new MapperConfiguration(cfg => cfg.CreateMap<TranslEngRus, EngRusDTO>()
        //    .ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
        //    .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
        //    .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
        //    .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
        //    .ForMember(des => des.EngWord, x => x.MapFrom(src => src.EngWord.Word))
        //    .ForMember(des => des.RusWord, x => x.MapFrom(src => src.RusWord.Word)));//.ReverseMap()/*reversemap?*/);

        //    //hz reverse mapping
        //    var configEngRusViseVersa = new MapperConfiguration(cfg => cfg.CreateMap<EngRusDTO, TranslEngRus>()
        //    .ForMember(des => des.IdTranslation, x => x.MapFrom(src => src.ID))
        //    .ForMember(des => des.PartOfSpeech.Partname, x => x.MapFrom(src => src.PartOfSpeech))
        //    .ForMember(des => des.Subcategory.Subcategoryname, x => x.MapFrom(src => src.Subcategory))
        //    .ForMember(des => des.Subcategory.Category.Categoryname, x => x.MapFrom(src => src.Category))
        //    .ForMember(des => des.EngWord.Word, x => x.MapFrom(src => src.EngWord))
        //    .ForMember(des => des.RusWord.Word, x => x.MapFrom(src => src.RusWord)));


        //    ///

        //    ////v.2
        //    //Mapper.Initialize(cfg => cfg.CreateMap<TranslRusEst, RusEstDTO>().ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
        //    //.ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
        //    //.ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
        //    //.ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
        //    //.ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
        //    //.ForMember(des => des.RusWord, x => x.MapFrom(src => src.RusWord.Word))
        //    //.ForMember(des => des.EstWord, x => x.MapFrom(src => src.EstWord.Word)).ReverseMap()/*reversemap?*/);

        //    var configRusEst = new MapperConfiguration(cfg => cfg.CreateMap<TranslRusEst, RusEstDTO>().ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
        //    .ForMember(des => des.ID, x => x.MapFrom(src => src.IdTranslation))
        //    .ForMember(des => des.PartOfSpeech, x => x.MapFrom(src => src.PartOfSpeech.Partname))
        //    .ForMember(des => des.Subcategory, x => x.MapFrom(src => src.Subcategory.Subcategoryname))
        //    .ForMember(des => des.Category, x => x.MapFrom(src => src.Subcategory.Category.Categoryname))
        //    .ForMember(des => des.RusWord, x => x.MapFrom(src => src.RusWord.Word))
        //    .ForMember(des => des.EstWord, x => x.MapFrom(src => src.EstWord.Word)).ReverseMap()/*reversemap?*/);

        //    //hz reverse mapping
        //    var configRusEstViseVersa = new MapperConfiguration(cfg => cfg.CreateMap<RusEstDTO, TranslRusEst>()
        //    .ForMember(des => des.IdTranslation, x => x.MapFrom(src => src.ID))
        //    .ForMember(des => des.PartOfSpeech.Partname, x => x.MapFrom(src => src.PartOfSpeech))
        //    .ForMember(des => des.Subcategory.Subcategoryname, x => x.MapFrom(src => src.Subcategory))
        //    .ForMember(des => des.Subcategory.Category.Categoryname, x => x.MapFrom(src => src.Category))
        //    .ForMember(des => des.RusWord.Word, x => x.MapFrom(src => src.RusWord))
        //    .ForMember(des => des.EstWord.Word, x => x.MapFrom(src => src.EstWord)));

        //    //.ForMember(dest => dest.Author,
        //    //           opts => opts.MapFrom(src => src.Author.Name));
        //}

        //public static void Example()
        //{


        //}


    }
}
