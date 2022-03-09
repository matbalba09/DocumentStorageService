using DocumentStorageService.Core;
using DocumentStorageService.Core.Domain;
using DocumentStorageService.Core.Repositories;
using DocumentStorageService.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocumentStorageService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DocumentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Document> GetAll()
        {
            return _unitOfWork.document.GetAll();
        }

        [HttpPost]
        public void AddDocument(Document document)
        {
            _unitOfWork.document.Add(document);
            _unitOfWork.Complete();
        }
    }
}
