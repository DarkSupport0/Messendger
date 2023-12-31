﻿namespace Messenger.SQL.CQRS.Core
{
    public interface IAsyncCommand
    {
        Task Execute();
    }

    public interface IAsyncCommand<TResult>
    {
        Task<TResult> Execute();
    }

    public interface IAsyncCommand<in TData, TResult>
    {
        Task<TResult> Execute(TData data);
    }
}
