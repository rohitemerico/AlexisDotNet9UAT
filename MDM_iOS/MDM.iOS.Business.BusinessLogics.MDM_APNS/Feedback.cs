﻿/*Copyright 2011 Arash Norouzi

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

namespace MDM.iOS.Business.BusinessLogics.MDM_APNS
{
    /// <summary>
    /// Feedback entity which is used in the process of Apple Push Notification Service (APNS). 
    /// </summary>
    public class Feedback
    {

        /// <summary>
        /// Constructor for feedback entity
        /// </summary>
        public Feedback()
        {
            this.DeviceToken = string.Empty;
            this.Timestamp = DateTime.MinValue;
        }

        /// <summary>
        /// Device Token string in hex form without any spaces or dashes
        /// </summary>
        public string DeviceToken
        {
            get;
            set;
        }

        /// <summary>
        /// Timestamp of the Feedback for when Apple received the notice to stop sending notifications to the device
        /// </summary>
        public DateTime Timestamp
        {
            get;
            set;
        }
    }
}
