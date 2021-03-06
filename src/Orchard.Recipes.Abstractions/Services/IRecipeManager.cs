﻿using Orchard.Recipes.Models;

namespace Orchard.Recipes.Services
{
    public interface IRecipeManager
    {
        string Execute(Recipe recipe);
    }
}