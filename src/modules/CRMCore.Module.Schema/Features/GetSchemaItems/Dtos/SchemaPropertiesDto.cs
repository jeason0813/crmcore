﻿using System.ComponentModel.DataAnnotations;

namespace CRMCore.Module.Schema.Features.GetSchemaItems.Dtos
{
    public sealed class SchemaPropertiesDto
    {
        [StringLength(50)]
        public string Label { get; set; }

        [StringLength(100)]
        public string Hints { get; set; }
    }
}