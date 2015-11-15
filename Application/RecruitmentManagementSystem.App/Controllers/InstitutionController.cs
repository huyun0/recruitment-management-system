﻿using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using RecruitmentManagementSystem.App.ViewModels.Candidate;
using RecruitmentManagementSystem.Data.Interfaces;
using JsonResult = RecruitmentManagementSystem.App.Infrastructure.ActionResults.JsonResult;

namespace RecruitmentManagementSystem.App.Controllers
{
    [Authorize]
    public class InstitutionController : BaseController
    {
        private readonly IInstitutionRepository _institutionRepository;

        public InstitutionController(IInstitutionRepository institutionRepository)
        {
            _institutionRepository = institutionRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _institutionRepository.FindAll().ProjectTo<InstitutionViewModel>();

            return new JsonResult(model, JsonRequestBehavior.AllowGet);
        }
    }
}