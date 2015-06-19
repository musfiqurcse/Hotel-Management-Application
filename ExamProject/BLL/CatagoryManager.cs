using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamProject.DAL.DAO;
using ExamProject.DAL.Gateway;

namespace ExamProject.BLL
{
    public class CatagoryManager
    {
        CatagoryGateway catagoryLink=new CatagoryGateway();
        public List<Catagory> GetCatagory()
        {
            return catagoryLink.GetCatagoryList();
        } 
    }
}