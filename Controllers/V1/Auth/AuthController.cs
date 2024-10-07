// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using PruebaNET_JulianForero.Repositories;

// namespace PruebaNET_JulianForero.Controller.V1.Auth
// {
//     [Route("api/v1/auth")]
//     [ApiExplorerSettings(GroupName = "v1")]
//     public class AuthController : ControllerBase
//     {
//         protected readonly IEmployeeRepository servicios;

//         public AuthController(IEmployeeRepository userRepository)
//         {
//             servicios = userRepository;
//         }

//         [HttpPost]
//         [Route("login")]
//         public async Task<IActionResult> Login(LoginDTO data)
//         {
//             var user = await servicios.GetByEmail(data.Email);

//             if (user == null)
//             {
//                 return BadRequest("El usuario no existe");
//             }

//             // Verificar la contraseña hasheada
//             bool isPasswordValid = PasswordHasher.VerifyPassword(data.Password, user.Password);

//             if (!isPasswordValid)
//             {
//                 return BadRequest("Contraseña incorrecta");
//             }

//             if (user.Role != true)
//             {
//                 return Unauthorized($"Suerte, no tiene los permisos necesarios");
//             }

//             var token = JWT.GenerateJwtToken(user);

//             return Ok($"ACA ESTA SU TOKEN: {token}");
//         }

//     }
// }