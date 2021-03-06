using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class FileTypeList :  IEquatable<FileTypeList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileTypeList" /> class.
        /// </summary>
        public FileTypeList()
        {
            
        }

        
        /// <summary>
        /// A collection of file types.
        /// </summary>
        /// <value>A collection of file types.</value>
        [DataMember(Name="fileTypes", EmitDefaultValue=false)]
        public List<FileType> FileTypes { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileTypeList {\n");
            sb.Append("  FileTypes: ").Append(FileTypes).Append("\n");
            
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
            return this.Equals(obj as FileTypeList);
        }

        /// <summary>
        /// Returns true if FileTypeList instances are equal
        /// </summary>
        /// <param name="other">Instance of FileTypeList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileTypeList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FileTypes == other.FileTypes ||
                    this.FileTypes != null &&
                    this.FileTypes.SequenceEqual(other.FileTypes)
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
                
                if (this.FileTypes != null)
                    hash = hash * 59 + this.FileTypes.GetHashCode();
                
                return hash;
            }
        }

    }
}
