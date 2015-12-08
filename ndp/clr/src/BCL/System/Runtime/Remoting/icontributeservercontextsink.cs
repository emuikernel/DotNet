// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
//  The IContributeServerContextSink interface is implemented by 
//  context properties in a Context that wish to contribute 
//  an interception sink at the context boundary on the server end 
//  of a remoting call.
//
namespace System.Runtime.Remoting.Contexts {

    using System;
    using System.Runtime.Remoting.Messaging;    
    using System.Security.Permissions;
    /// <internalonly/>
    [System.Runtime.InteropServices.ComVisible(true)]
    public interface IContributeServerContextSink
    {
        /// <internalonly/>
        // Chain your message sink in front of the chain formed thus far and 
        // return the composite sink chain.
        // 
        [System.Security.SecurityCritical]  // auto-generated_required
        IMessageSink GetServerContextSink(IMessageSink nextSink);
    }
}
