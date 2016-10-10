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
 * Pod API
 *
 * This document refers to Symphony API calls that do not need encryption or decryption of content.  - sessionToken can be obtained by calling the authenticationAPI on the symphony back end and the key manager respectively. Refer to the methods described in authenticatorAPI.yaml. - Actions are defined to be atomic, ie will succeed in their entirety or fail and have changed nothing. - If it returns a 40X status then it will have made no change to the system even if ome subset of the request would have succeeded. - If this contract cannot be met for any reason then this is an error and the response code will be 50X. 
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

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model
{
    /// <summary>
    /// Presence
    /// </summary>
    [DataContract]
    public partial class Presence :  IEquatable<Presence>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum UNDEFINED for "UNDEFINED"
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            UNDEFINED,
            
            /// <summary>
            /// Enum AVAILABLE for "AVAILABLE"
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            AVAILABLE,
            
            /// <summary>
            /// Enum BUSY for "BUSY"
            /// </summary>
            [EnumMember(Value = "BUSY")]
            BUSY,
            
            /// <summary>
            /// Enum DONOTDISTURB for "DO_NOT_DISTURB"
            /// </summary>
            [EnumMember(Value = "DO_NOT_DISTURB")]
            DONOTDISTURB,
            
            /// <summary>
            /// Enum ONTHEPHONE for "ON_THE_PHONE"
            /// </summary>
            [EnumMember(Value = "ON_THE_PHONE")]
            ONTHEPHONE,
            
            /// <summary>
            /// Enum BERIGHTBACK for "BE_RIGHT_BACK"
            /// </summary>
            [EnumMember(Value = "BE_RIGHT_BACK")]
            BERIGHTBACK,
            
            /// <summary>
            /// Enum AWAY for "AWAY"
            /// </summary>
            [EnumMember(Value = "AWAY")]
            AWAY,
            
            /// <summary>
            /// Enum OFFLINE for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            OFFLINE
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Presence" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        public Presence(CategoryEnum? Category = null)
        {
            this.Category = Category;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Presence {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as Presence);
        }

        /// <summary>
        /// Returns true if Presence instances are equal
        /// </summary>
        /// <param name="other">Instance of Presence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Presence other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
