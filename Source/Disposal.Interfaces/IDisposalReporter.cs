// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDisposalReporter.cs" company="Sundews">
// Copyright (c) Sundews. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Disposal.Interfaces;

using System;

/// <summary>
/// Interface for implementing a disposal reporter.
/// </summary>
public interface IDisposalReporter
{
    /// <summary>
    /// Called when a disposable has been disposed.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="disposable">The disposable.</param>
    void Disposed(object source, IDisposable disposable);
#if NETSTANDARD2_0_OR_GREATER
    /// <summary>
    /// Called when an async disposable has been disposed.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="disposable">The disposable.</param>
    void Disposed(object source, IAsyncDisposable disposable);
#endif
}