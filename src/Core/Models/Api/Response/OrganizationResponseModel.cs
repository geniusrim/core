﻿using System;
using Bit.Core.Models.Table;

namespace Bit.Core.Models.Api
{
    public class OrganizationResponseModel : ResponseModel
    {
        public OrganizationResponseModel(Organization organization, string obj = "organization")
            : base(obj)
        {
            if(organization == null)
            {
                throw new ArgumentNullException(nameof(organization));
            }

            Id = organization.Id.ToString();
            Name = organization.Name;
            Plan = organization.Plan;
            PlanType = organization.PlanType;
            PlanTrial = organization.PlanTrial;
            MaxUsers = organization.MaxUsers;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Plan { get; set; }
        public Enums.PlanType PlanType { get; set; }
        public bool PlanTrial { get; set; }
        public short MaxUsers { get; set; }
    }
}
