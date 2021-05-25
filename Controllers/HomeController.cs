using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopBridge.DateAccess.Interface;
using ShopBridge.Framework.StorageClass;
using ShopBridge.Models;
using System.Threading.Tasks;

namespace ShopBridge.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;
        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository) : base(logger)
        {
            _logger = logger;
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Entered into Index in HomeController");
            ProductViewModel productViewModel = new ProductViewModel();
            try
            {
                productViewModel.ProductList = await _productRepository.GetAllProducts();
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error while return index view in HomeController");
            }
            return View(productViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> EditProduct(int productId, string mode)
        {
            _logger.LogInformation("Entered into EditProduct in HomeController");
            if (ModelState.IsValid == false)
            {
                return BadRequest("Invalid data");
            }
            if (productId <= 0 || string.IsNullOrEmpty(mode))
            {
                return NoContent();
            }
            var product = await _productRepository.GetProductById(productId);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            ViewData["Title"] = "Edit Product";
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.BuildProductInformation(product, mode);
            return PartialView("ProductEditorPage", productViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> NewProduct()
        {
            _logger.LogInformation("Entered into NewProduct in HomeController");
            if (ModelState.IsValid == false)
            {
                return BadRequest("Invalid data");
            }
            ViewData["Title"] = "Add Product";
            return PartialView("ProductEditorPage", new ProductViewModel());
        }
        [HttpGet]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            _logger.LogInformation("Entered into DeleteProduct in HomeController");
            ProductViewModel productViewModel = new ProductViewModel();
            await _productRepository.DeleteProduct(productId);
            productViewModel.ProductList = await _productRepository.GetAllProducts();
            return RedirectToAction("Index", productViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> SaveProduct(ProductViewModel productViewModel)
        {
            _logger.LogInformation("Entered into SaveProduct in HomeController");
            if (ModelState.IsValid == false)
            {
                return BadRequest("Invalid data");
            }
            if (productViewModel == null)
            {
                return NoContent();
            }
            Product product = new Product();
            productViewModel.BuildProductInfoStorage(product);
            if (productViewModel.Mode == "Edit" && productViewModel.ProductID != 0)
            {
                await _productRepository.UpdateProduct(product);
            }
            else
            {
                await _productRepository.AddProduct(product);
            }
            return RedirectToAction("Index", productViewModel);
        }
    }
}
