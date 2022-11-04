using FluentValidation.Results;
using Microsoft.AspNetCore.Http;

namespace OrderService.Domain.Core.DTO
{
    public class ServiceResult<T> : ServiceResult
    {
        public T Data { get; set; }

        public ServiceResult() : this(default(T)) { }
        public ServiceResult(T result) => this.Data = result;
    }

    public class ServiceResult
    {
        public int CodeId { get; set; } = StatusCodes.Status200OK;
        public string Message { get; set; }
        public bool IsSuccess { get { return !(Errors?.Count > 0); } }
        public List<ErrorResultDetail> Errors { get; set; } = new List<ErrorResultDetail>();

        public void AddError(string message)
        {
            var errosDetail = new ErrorResultDetail(ErrorResultDetail.BAD_REQUEST.Code, message) { StatusCode = StatusCodes.Status400BadRequest };
            AddError(errosDetail);
        }

        public void AddError(int codeId, string code, string message = null)
        {
            AddError(codeId, new ErrorResultDetail(code, message));
        }

        public void AddError(ErrorResultDetail errorResultDetail)
        {
            int codeId = errorResultDetail.StatusCode ?? StatusCodes.Status400BadRequest;
            AddError(codeId, errorResultDetail);
        }

        public void AddError(int codeId, ErrorResultDetail errorResultDetail)
        {
            this.CodeId = this.CodeId > codeId
                ? this.CodeId
                : codeId;

            Errors.Add(errorResultDetail);
        }

        public void AddErrors(IEnumerable<ValidationFailure> errors)
        {
            AddErrors(StatusCodes.Status400BadRequest, errors);
        }

        public void AddErrors(int codeId, IEnumerable<ValidationFailure> errors)
        {
            foreach (var error in errors)
                AddError(codeId, error.ErrorCode, error.ErrorMessage);
        }

        public bool ContainsError(string code)
        {
            var result = false;

            if (Errors != null)
                result = Errors.Any(p => p.Code == code || p.Details.Any(x => x.Code == code));

            return result;
        }
    }
}
