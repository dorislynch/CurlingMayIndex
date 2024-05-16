using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Curling.May.Index.RNCurlingMayIndex
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCurlingMayIndexModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCurlingMayIndexModule"/>.
        /// </summary>
        internal RNCurlingMayIndexModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCurlingMayIndex";
            }
        }
    }
}
