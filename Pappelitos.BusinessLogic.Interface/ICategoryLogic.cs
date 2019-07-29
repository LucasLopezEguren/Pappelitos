using System;
using Pappelitos.Domain;

namespace Pappelitos.BusinessLogic.Interface
{
    public interface ICategoryLogic 
    {
        Category AddCategory(Category toAdd);
        Category UpdateCategory(Category toUpdate);
        void DeleteCategory(int id);
    }
}
