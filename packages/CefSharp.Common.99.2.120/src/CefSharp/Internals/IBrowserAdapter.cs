// Copyright ? 2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;

namespace CefSharp.Internals
{
    /// <summary>
    /// Interface used to break reference cycles in CefSharp.Core C++ code.
    /// This will ALWAYS be a ManagedCefBrowserAdapter instance.
    /// </summary>
    public interface IBrowserAdapter : IDisposable
    {
        void CreateBrowser(IWindowInfo windowInfo, IBrowserSettings browserSettings, IRequestContext requestContext, string address);
        IMethodRunnerQueue MethodRunnerQueue { get; }
        IJavascriptObjectRepositoryInternal JavascriptObjectRepository { get; }
        IJavascriptCallbackFactory JavascriptCallbackFactory { get; }
        void OnAfterBrowserCreated(IBrowser browser);
        IBrowser GetBrowser(int browserId);
        bool IsDisposed { get; }
        void Resize(int width, int height);
    }
}
