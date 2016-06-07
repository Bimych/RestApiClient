using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// Generated when a room is created.
    /// </summary>
    [DataContract]
    public partial class RoomCreatedMessage : V2BaseMessage,  IEquatable<RoomCreatedMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomCreatedMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomCreatedMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomCreatedMessage" /> class.
        /// </summary>
        /// <param name="Id">The messageId is assigned by the ingestor service when a message is sent..</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="V2messageType">V2messageType (required).</param>
        /// <param name="StreamId">StreamId (required).</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Keywords">Keywords.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreatedByUserId">The Symphony userId of the user who created the room..</param>
        /// <param name="_ReadOnly">_ReadOnly.</param>
        /// <param name="Discoverable">Discoverable.</param>
        /// <param name="_Public">_Public.</param>
        /// <param name="MembersCanInvite">MembersCanInvite.</param>
        /// <param name="CopyProtected">CopyProtected.</param>
        public RoomCreatedMessage(string Id = null, string Timestamp = null, string V2messageType = null, string StreamId = null, long? CreationDate = null, string Name = null, List<RoomTag> Keywords = null, string Description = null, long? CreatedByUserId = null, bool? _ReadOnly = null, bool? Discoverable = null, bool? _Public = null, bool? MembersCanInvite = null, bool? CopyProtected = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for RoomCreatedMessage and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "V2messageType" is required (not null)
            if (V2messageType == null)
            {
                throw new InvalidDataException("V2messageType is a required property for RoomCreatedMessage and cannot be null");
            }
            else
            {
                this.V2messageType = V2messageType;
            }
            // to ensure "StreamId" is required (not null)
            if (StreamId == null)
            {
                throw new InvalidDataException("StreamId is a required property for RoomCreatedMessage and cannot be null");
            }
            else
            {
                this.StreamId = StreamId;
            }
            
            
                        this.Id = Id;
            
                        this.CreationDate = CreationDate;
            
                        this.Name = Name;
            
                        this.Keywords = Keywords;
            
                        this.Description = Description;
            
                        this.CreatedByUserId = CreatedByUserId;
            
                        this._ReadOnly = _ReadOnly;
            
                        this.Discoverable = Discoverable;
            
                        this._Public = _Public;
            
                        this.MembersCanInvite = MembersCanInvite;
            
                        this.CopyProtected = CopyProtected;
            
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
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public long? CreationDate { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<RoomTag> Keywords { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The Symphony userId of the user who created the room.
        /// </summary>
        /// <value>The Symphony userId of the user who created the room.</value>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public long? CreatedByUserId { get; set; }
        /// <summary>
        /// Gets or Sets _ReadOnly
        /// </summary>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }
        /// <summary>
        /// Gets or Sets Discoverable
        /// </summary>
        [DataMember(Name="discoverable", EmitDefaultValue=false)]
        public bool? Discoverable { get; set; }
        /// <summary>
        /// Gets or Sets _Public
        /// </summary>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool? _Public { get; set; }
        /// <summary>
        /// Gets or Sets MembersCanInvite
        /// </summary>
        [DataMember(Name="membersCanInvite", EmitDefaultValue=false)]
        public bool? MembersCanInvite { get; set; }
        /// <summary>
        /// Gets or Sets CopyProtected
        /// </summary>
        [DataMember(Name="copyProtected", EmitDefaultValue=false)]
        public bool? CopyProtected { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomCreatedMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
sb.Append("  V2messageType: ").Append(V2messageType).Append("\n");
sb.Append("  StreamId: ").Append(StreamId).Append("\n");
sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Keywords: ").Append(Keywords).Append("\n");
sb.Append("  Description: ").Append(Description).Append("\n");
sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
sb.Append("  Discoverable: ").Append(Discoverable).Append("\n");
sb.Append("  _Public: ").Append(_Public).Append("\n");
sb.Append("  MembersCanInvite: ").Append(MembersCanInvite).Append("\n");
sb.Append("  CopyProtected: ").Append(CopyProtected).Append("\n");
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
            return this.Equals(obj as RoomCreatedMessage);
        }

        /// <summary>
        /// Returns true if RoomCreatedMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomCreatedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomCreatedMessage other)
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
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(other.Keywords)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.CreatedByUserId == other.CreatedByUserId ||
                    this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.Discoverable == other.Discoverable ||
                    this.Discoverable != null &&
                    this.Discoverable.Equals(other.Discoverable)
                ) && 
                (
                    this._Public == other._Public ||
                    this._Public != null &&
                    this._Public.Equals(other._Public)
                ) && 
                (
                    this.MembersCanInvite == other.MembersCanInvite ||
                    this.MembersCanInvite != null &&
                    this.MembersCanInvite.Equals(other.MembersCanInvite)
                ) && 
                (
                    this.CopyProtected == other.CopyProtected ||
                    this.CopyProtected != null &&
                    this.CopyProtected.Equals(other.CopyProtected)
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
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CreatedByUserId != null)
                    hash = hash * 59 + this.CreatedByUserId.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.Discoverable != null)
                    hash = hash * 59 + this.Discoverable.GetHashCode();
                if (this._Public != null)
                    hash = hash * 59 + this._Public.GetHashCode();
                if (this.MembersCanInvite != null)
                    hash = hash * 59 + this.MembersCanInvite.GetHashCode();
                if (this.CopyProtected != null)
                    hash = hash * 59 + this.CopyProtected.GetHashCode();
                return hash;
            }
        }
    }

}
