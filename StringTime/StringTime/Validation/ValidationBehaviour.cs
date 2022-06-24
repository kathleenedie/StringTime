﻿using FluentValidation;
using MediatR;

namespace StringTime.Validation
{
    //public sealed class ValidationBehaviour<TRequest, TResponse> :
    //    IPipelineBehavior<TRequest, TResponse>
    //    where TRequest : IRequest<TResponse>
    //{
    //    private readonly IEnumerable<IValidator<TRequest>> _validators;

    //    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators) =>
    //        _validators = validators;

    //    public async Task<TResponse> Handle(TRequest request, CancellationToken
    //            cancellationToken,
    //        RequestHandlerDelegate<TResponse> next)
    //    {
    //        if (!_validators.Any())
    //            return await next();

    //        var context = new ValidationContext<TRequest>(request);
    //        var errorsDictionary = _validators
    //            .Select(x => x.Validate(context))
    //            .SelectMany(x => x.Errors)
    //            .Where(x => x != null)
    //            .GroupBy(
    //                x => x.PropertyName.Substring(x.PropertyName.IndexOf('.') + 1),
    //                x => x.ErrorMessage,
    //                (propertyName, errorMessages) => new
    //                {
    //                    Key = propertyName,
    //                    Values = errorMessages.Distinct().ToArray()
    //                })
    //            .ToDictionary(x => x.Key, x => x.Values);
    //        if (errorsDictionary.Any())
    //            throw new FluentValidationExceptions(errorsDictionary);
    //        return await next();
    //    }
    //}
}