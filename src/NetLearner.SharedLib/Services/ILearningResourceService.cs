﻿using NetLearner.SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetLearner.SharedLib.Services
{
    public interface ILearningResourceService
    {
        Task<List<LearningResource>> Get();
        Task<LearningResource> Get(int id);
        Task<LearningResource> Add(LearningResource learningResource);
        Task<LearningResource> Update(LearningResource learningResource);
        Task<LearningResource> Delete(int id);
    }
}