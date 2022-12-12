namespace FrontToBackEnd.Application.Common;
public record ResponseModel(int StatusCode, string Message = null)
{
    public static ResponseModel Ok(string message = null) => new(200, message);

    public static ResponseModel Created(string message = null) => new(201, message);

    public static ResponseModel Accepted(string message = null) => new(202, message);

    public static ResponseModel BadRequest(string message) => new(400, message);

    public static ResponseModel Forbidden(string message = null) => new(403, message);

    public static ResponseModel NotFound(string message = null) => new(404, message);

    public static ResponseModel ImATeapot(string message = "I'm a teapot") => new(418, message);

    public static ResponseModel InternalServerError(string message = null) => new(500, message);

    public static ResponseModel<T> Ok<T>(T Content, string message = null) => new(200, Content, message);

    public static ResponseModel<T> Created<T>(string message = null) => new(201, default, message);

    public static ResponseModel<T> Accepted<T>(string message = null) => new(202, default, message);

    public static ResponseModel<T> BadRequest<T>(string message) => new(400, default, message);

    public static ResponseModel<T> Forbidden<T>(string message = null) => new(403, default, message);

    public static ResponseModel<T> NotFound<T>(string message = null) => new(404, default, message);

    public static ResponseModel<T> ImATeapot<T>(string message = "I'm a teapot") => new(418, default, message);

    public static ResponseModel<T> InternalServerError<T>(string message = null) => new(500, default, message);
}

public record ResponseModel<T>(int StatusCode, T Content = default, string Message = null) { }