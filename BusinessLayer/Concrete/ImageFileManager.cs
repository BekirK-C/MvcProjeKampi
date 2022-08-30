using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _İmagefileDal;

        public ImageFileManager(IImageFileDal imagefileDal)
        {
            _İmagefileDal = imagefileDal;
        }

        public List<ImageFile> GetList()
        {
            return _İmagefileDal.List();
        }
    }
}
