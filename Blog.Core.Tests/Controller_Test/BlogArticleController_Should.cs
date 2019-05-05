using Blog.Core.Common;
using Blog.Core.Controllers;
using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Moq;
using Xunit;
using System;

namespace Blog.Core.Tests
{
    public class BlogArticleController_Should
    {
        Mock<IBlogArticleServices> mockBlogSev = new Mock<IBlogArticleServices>();
        Mock<IRedisCacheManager> mockRedisMag = new Mock<IRedisCacheManager>();
        BlogController blogController;

        public BlogArticleController_Should()
        {
            mockBlogSev.Setup(r => r.Query());
            blogController = new BlogController(mockBlogSev.Object, mockRedisMag.Object);
        }

        [Fact]
        public void TestEntity()
        {
            BlogArticle blogArticle = new BlogArticle();

            Assert.True(blogArticle.bID >= 0);
        }
        [Fact]
        public async void AddEntity()
        {
            BlogArticle blogArticle = new BlogArticle()
            {
                bCreateTime = DateTime.Now,
                bUpdateTime = DateTime.Now,
                btitle = "xuint :test controller addEntity",

            };

            var res = await blogController.Post(blogArticle);

            Assert.True(res.success);

            var data = res.response;

            Assert.NotNull(data);
        }
    }
}
