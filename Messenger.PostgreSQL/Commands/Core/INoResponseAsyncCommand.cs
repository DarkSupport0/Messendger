﻿namespace Messenger.PostgreSQL.Commands.Core;

public interface INoResponseAsyncCommand<in TData>
{
    Task Execute(TData data);
}