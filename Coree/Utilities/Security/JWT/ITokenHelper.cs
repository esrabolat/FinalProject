﻿using Coree.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coree.Utilities.Security.JWT
{
    
        public interface ITokenHelper
        {
            AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        }

    
}
