using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;
using System.Data;

namespace BusinessLogicLayer
{
    public class RequestBL
    {
        public DataSet GetAllPendingRequest(string branchCode)
        {
            RequestDAL rdal = new RequestDAL();
            return rdal.SelectAllPendingRequest(branchCode);
        }

        public DataSet GetAllAcceptRequest(DateTime from, DateTime to, string request)
        {
            RequestDAL rdal = new RequestDAL();
            return rdal.SelectAllAcceptRequest(from, to, request);
        }

        public bool EditRequest(string Req_Id, string Status)
        {
            RequestDAL rdal = new RequestDAL();
            return rdal.UpdateReq(Req_Id, Status);
        }

        public Request CheckRequestStatus(Request request)
        {
            RequestDAL requestDAL = new RequestDAL();
            return requestDAL.SelectRequest(request);
        }

        public bool IsValidRequest(Request request, string cifNo)
        {
            RequestDAL requestDAL = new RequestDAL();
            return requestDAL.CheckRequest(request, cifNo);
        }

        public DataSet GetAllBranchCode()
        {
            BranchDAL branchDAL = new BranchDAL();
            return branchDAL.SelectAllBranchCode();
        }

        public string AddRequest(Request request)
        {
            RequestDAL requestDAL = new RequestDAL();
            return requestDAL.InsertRequest(request);
        }
    }
}
