// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// <auto-generated />

using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

#nullable enable

namespace Microsoft.EntityFrameworkCore.Query.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public class CompiledAsyncTaskQuery<TContext, TResult> : CompiledQueryBase<TContext, Task<TResult>>
        where TContext : DbContext
    {
        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public CompiledAsyncTaskQuery([NotNull] LambdaExpression queryExpression)
            : base(queryExpression)
        {
        }

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync(
            [NotNull] TContext context)
            => ExecuteCore(context);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync(
            [NotNull] TContext context, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1)
            => ExecuteCore(context, param1);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2)
            => ExecuteCore(context, param1, param2);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3)
            => ExecuteCore(context, param1, param2, param3);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4)
            => ExecuteCore(context, param1, param2, param3, param4);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5)
            => ExecuteCore(context, param1, param2, param3, param4, param5);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6, param7);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7, param8);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6, param7, param8);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7, param8, param9);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6, param7, param8, param9);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11, [CanBeNull] TParam12 param12)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11, [CanBeNull] TParam12 param12, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11, [CanBeNull] TParam12 param12, [CanBeNull] TParam13 param13)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11, [CanBeNull] TParam12 param12, [CanBeNull] TParam13 param13, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11, [CanBeNull] TParam12 param12, [CanBeNull] TParam13 param13, [CanBeNull] TParam14 param14)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11, [CanBeNull] TParam12 param12, [CanBeNull] TParam13 param13, [CanBeNull] TParam14 param14, CancellationToken cancellationToken)
            => ExecuteCore(context, cancellationToken, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14);

        /// <summary>
        ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
        ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
        ///     any release. You should only use it directly in your code with extreme caution and knowing that
        ///     doing so can result in application failures when updating to a new Entity Framework Core release.
        /// </summary>
        public virtual Task<TResult> ExecuteAsync<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15>(
            [NotNull] TContext context, [CanBeNull] TParam1 param1, [CanBeNull] TParam2 param2, [CanBeNull] TParam3 param3, [CanBeNull] TParam4 param4, [CanBeNull] TParam5 param5, [CanBeNull] TParam6 param6, [CanBeNull] TParam7 param7, [CanBeNull] TParam8 param8, [CanBeNull] TParam9 param9, [CanBeNull] TParam10 param10, [CanBeNull] TParam11 param11, [CanBeNull] TParam12 param12, [CanBeNull] TParam13 param13, [CanBeNull] TParam14 param14, [CanBeNull] TParam15 param15)
            => ExecuteCore(context, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15);

        /// <inheritdoc />
        protected override Func<QueryContext, Task<TResult>> CreateCompiledQuery(
            IQueryCompiler queryCompiler, Expression expression)
            => queryCompiler.CreateCompiledAsyncQuery<Task<TResult>>(expression);
    }
}
