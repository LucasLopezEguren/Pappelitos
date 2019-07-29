using System;
using Pappelitos.Domain;
using Pappelitos.BusinessLogic.Interface;
using Pappelitos.DataAccess.Interface;

namespace Pappelitos.BusinessLogic
{
    public class CategoryLogic : ICategoryLogic
    {
        private IRepository<Category> categoryRepository;
        public CategoryLogic(IRepository<Category> repository)
        {
            this.categoryRepository = repository;
        }
        public Category AddCategory(Category category)
        {
            categoryRepository.Add(category);
            categoryRepository.Save();
            return category;
        }
        public void DeleteCategory(int id)
        {
            Category toDelete = categoryRepository.GetByID(id);
            categoryRepository.Delete(toDelete);
            categoryRepository.Save();
        }
        public Category UpdateCategory(Category category)
        {
            categoryRepository.Update(category);
            categoryRepository.Save();
            return category;
        }
    }
}
