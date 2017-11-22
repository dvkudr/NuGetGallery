﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace NuGetGallery.Areas.Admin.ViewModels
{
    public class DeleteUserAccountViewModel : DeleteAccountViewModel
    {
        public DeleteUserAccountViewModel()
        {
            ShouldUnlist = true;
        }

        [Required(ErrorMessage = "Please sign using your name.")]
        [StringLength(1000)]
        [Display(Name = "Signature")]
        public string Signature { get; set; }

        [Display(Name = "Unlist the packages with no other owners.")]
        public bool ShouldUnlist { get; set; }
    }

}
