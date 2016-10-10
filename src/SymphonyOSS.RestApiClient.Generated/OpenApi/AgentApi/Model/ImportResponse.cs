﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
/* 
 * Agent API
 *
 * This document refers to Symphony API calls to send and receive messages and content. They need the on-premise Agent installed to perform decryption/encryption of content.  - sessionToken and keyManagerToken can be obtained by calling the authenticationAPI on the symphony back end and the key manager respectively. Refer to the methods described in authenticatorAPI.yaml. - Actions are defined to be atomic, ie will succeed in their entirety or fail and have changed nothing. - If it returns a 40X status then it will have sent no message to any stream even if a request to aome subset of the requested streams would have succeeded. - If this contract cannot be met for any reason then this is an error and the response code will be 50X. - MessageML is a markup language for messages. See reference here: https://developers.symphony.com/documentation/message_format_reference 
 *
 * OpenAPI spec version: 1.38.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// ImportResponse
    /// </summary>
    [DataContract]
    public partial class ImportResponse :  IEquatable<ImportResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportResponse" /> class.
        /// </summary>
        /// <param name="MessageId">If the message was successfully imported then the message ID in the system of the newly created message. .</param>
        /// <param name="Diagnostic">A diagnostic message containing an error message in the event that the message import failed. May also be present in the case of a successful call if there is useful narrative to return. .</param>
        public ImportResponse(string MessageId = null, string Diagnostic = null)
        {
            this.MessageId = MessageId;
            this.Diagnostic = Diagnostic;
        }
        
        /// <summary>
        /// If the message was successfully imported then the message ID in the system of the newly created message. 
        /// </summary>
        /// <value>If the message was successfully imported then the message ID in the system of the newly created message. </value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }
        /// <summary>
        /// A diagnostic message containing an error message in the event that the message import failed. May also be present in the case of a successful call if there is useful narrative to return. 
        /// </summary>
        /// <value>A diagnostic message containing an error message in the event that the message import failed. May also be present in the case of a successful call if there is useful narrative to return. </value>
        [DataMember(Name="diagnostic", EmitDefaultValue=false)]
        public string Diagnostic { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportResponse {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Diagnostic: ").Append(Diagnostic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ImportResponse);
        }

        /// <summary>
        /// Returns true if ImportResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) && 
                (
                    this.Diagnostic == other.Diagnostic ||
                    this.Diagnostic != null &&
                    this.Diagnostic.Equals(other.Diagnostic)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                if (this.Diagnostic != null)
                    hash = hash * 59 + this.Diagnostic.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
