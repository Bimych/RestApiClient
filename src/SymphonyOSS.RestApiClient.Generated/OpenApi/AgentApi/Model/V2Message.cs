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
    /// A representation of a message sent by a user of Symphony.
    /// </summary>
    [DataContract]
    public partial class V2Message : V2BaseMessage,  IEquatable<V2Message>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2Message" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V2Message() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2Message" /> class.
        /// </summary>
        /// <param name="Id">The messageId is assigned by the ingestor service when a message is sent..</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="V2messageType">V2messageType (required).</param>
        /// <param name="StreamId">StreamId (required).</param>
        /// <param name="Message">Message text in MessageML (required).</param>
        /// <param name="FromUserId">the Symphony userId of the user who sent the message. This will be populated by the server (and actually ignored if included when sending a message). (required).</param>
        /// <param name="Attachments">Attachments.</param>
        public V2Message(string Id = null, string Timestamp = null, string V2messageType = null, string StreamId = null, string Message = null, long? FromUserId = null, List<AttachmentInfo> Attachments = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for V2Message and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "V2messageType" is required (not null)
            if (V2messageType == null)
            {
                throw new InvalidDataException("V2messageType is a required property for V2Message and cannot be null");
            }
            else
            {
                this.V2messageType = V2messageType;
            }
            // to ensure "StreamId" is required (not null)
            if (StreamId == null)
            {
                throw new InvalidDataException("StreamId is a required property for V2Message and cannot be null");
            }
            else
            {
                this.StreamId = StreamId;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for V2Message and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "FromUserId" is required (not null)
            if (FromUserId == null)
            {
                throw new InvalidDataException("FromUserId is a required property for V2Message and cannot be null");
            }
            else
            {
                this.FromUserId = FromUserId;
            }
            this.Id = Id;
            this.Attachments = Attachments;
        }
        
        /// <summary>
        /// The messageId is assigned by the ingestor service when a message is sent.
        /// </summary>
        /// <value>The messageId is assigned by the ingestor service when a message is sent.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets V2messageType
        /// </summary>
        [DataMember(Name="v2messageType", EmitDefaultValue=false)]
        public string V2messageType { get; set; }
        /// <summary>
        /// Gets or Sets StreamId
        /// </summary>
        [DataMember(Name="streamId", EmitDefaultValue=false)]
        public string StreamId { get; set; }
        /// <summary>
        /// Message text in MessageML
        /// </summary>
        /// <value>Message text in MessageML</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// the Symphony userId of the user who sent the message. This will be populated by the server (and actually ignored if included when sending a message).
        /// </summary>
        /// <value>the Symphony userId of the user who sent the message. This will be populated by the server (and actually ignored if included when sending a message).</value>
        [DataMember(Name="fromUserId", EmitDefaultValue=false)]
        public long? FromUserId { get; set; }
        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<AttachmentInfo> Attachments { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  V2messageType: ").Append(V2messageType).Append("\n");
            sb.Append("  StreamId: ").Append(StreamId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  FromUserId: ").Append(FromUserId).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as V2Message);
        }

        /// <summary>
        /// Returns true if V2Message instances are equal
        /// </summary>
        /// <param name="other">Instance of V2Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2Message other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.V2messageType == other.V2messageType ||
                    this.V2messageType != null &&
                    this.V2messageType.Equals(other.V2messageType)
                ) && 
                (
                    this.StreamId == other.StreamId ||
                    this.StreamId != null &&
                    this.StreamId.Equals(other.StreamId)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.FromUserId == other.FromUserId ||
                    this.FromUserId != null &&
                    this.FromUserId.Equals(other.FromUserId)
                ) && 
                (
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(other.Attachments)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.V2messageType != null)
                    hash = hash * 59 + this.V2messageType.GetHashCode();
                if (this.StreamId != null)
                    hash = hash * 59 + this.StreamId.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.FromUserId != null)
                    hash = hash * 59 + this.FromUserId.GetHashCode();
                if (this.Attachments != null)
                    hash = hash * 59 + this.Attachments.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
