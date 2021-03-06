using System;
using System.Data;
using System.Runtime.Serialization;

using CMS;
using CMS.DataEngine;
using CMS.Helpers;

using SupportHelper;

[assembly: RegisterObjectType(typeof(CustomMetricInfo), CustomMetricInfo.OBJECT_TYPE)]

namespace SupportHelper
{
    /// <summary>
    /// Data container class for <see cref="CustomMetricInfo"/>.
    /// </summary>
    [Serializable]
    public partial class CustomMetricInfo : AbstractInfo<CustomMetricInfo>
    {
        /// <summary>
        /// Object type.
        /// </summary>
        public const string OBJECT_TYPE = "supporthelper.custommetric";

        /// <summary>
        /// Type information.
        /// </summary>
        public static readonly ObjectTypeInfo TYPEINFO = new ObjectTypeInfo(typeof(CustomMetricInfoProvider), OBJECT_TYPE, "SupportHelper.CustomMetric", "CustomMetricID", null, null, "CustomMetricCodeName", "CustomMetricDisplayName", null, null, null, null)
        {
            ModuleName = "SupportHelper",
            TouchCacheDependencies = true,
        };

        /// <summary>
        /// Custom metric ID.
        /// </summary>
        [DatabaseField]
        public virtual int CustomMetricID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("CustomMetricID"), 0);
            }
            set
            {
                SetValue("CustomMetricID", value);
            }
        }

        /// <summary>
        /// Custom metric display name.
        /// </summary>
        [DatabaseField]
        public virtual string CustomMetricDisplayName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("CustomMetricDisplayName"), String.Empty);
            }
            set
            {
                SetValue("CustomMetricDisplayName", value);
            }
        }

        /// <summary>
        /// Custom metric code name.
        /// </summary>
        [DatabaseField]
        public virtual string CustomMetricCodeName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("CustomMetricCodeName"), String.Empty);
            }
            set
            {
                SetValue("CustomMetricCodeName", value, String.Empty);
            }
        }

        /// <summary>
        /// Custom metric assembly name.
        /// </summary>
        [DatabaseField]
        public virtual string CustomMetricAssemblyName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("CustomMetricAssemblyName"), String.Empty);
            }
            set
            {
                SetValue("CustomMetricAssemblyName", value);
            }
        }

        /// <summary>
        /// Custom metric class name.
        /// </summary>
        [DatabaseField]
        public virtual string CustomMetricClassName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("CustomMetricClassName"), String.Empty);
            }
            set
            {
                SetValue("CustomMetricClassName", value, String.Empty);
            }
        }

        /// <summary>
        /// Custom metric parent.
        /// </summary>
        [DatabaseField]
        public virtual string CustomMetricParent
        {
            get
            {
                return ValidationHelper.GetString(GetValue("CustomMetricParent"), String.Empty);
            }
            set
            {
                SetValue("CustomMetricParent", value);
            }
        }

        /// <summary>
        /// Custom metric selected.
        /// </summary>
        [DatabaseField]
        public virtual bool CustomMetricSelected
        {
            get
            {
                return ValidationHelper.GetBoolean(GetValue("CustomMetricSelected"), true);
            }
            set
            {
                SetValue("CustomMetricSelected", value);
            }
        }

        /// <summary>
        /// Deletes the object using appropriate provider.
        /// </summary>
        protected override void DeleteObject()
        {
            CustomMetricInfoProvider.DeleteCustomMetricInfo(this);
        }

        /// <summary>
        /// Updates the object using appropriate provider.
        /// </summary>
        protected override void SetObject()
        {
            CustomMetricInfoProvider.SetCustomMetricInfo(this);
        }

        /// <summary>
        /// Constructor for de-serialization.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected CustomMetricInfo(SerializationInfo info, StreamingContext context)
            : base(info, context, TYPEINFO)
        {
        }

        /// <summary>
        /// Creates an empty instance of the <see cref="CustomMetricInfo"/> class.
        /// </summary>
        public CustomMetricInfo()
            : base(TYPEINFO)
        {
        }

        /// <summary>
        /// Creates a new instances of the <see cref="CustomMetricInfo"/> class from the given <see cref="DataRow"/>.
        /// </summary>
        /// <param name="dr">DataRow with the object data.</param>
        public CustomMetricInfo(DataRow dr)
            : base(TYPEINFO, dr)
        {
        }
    }
}