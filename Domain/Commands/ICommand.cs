﻿namespace Domain.Commands
{
    public interface ICommand : IBaseCommand
    {
    }

    public interface ICommand<TResponse> : IBaseCommand
    {
    }
}
