using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.API.Models;

namespace ProAtividade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Atividadecontroller : ControllerBase
    {
    

    public IEnumerable<Atividade> Atividades = new List<Atividade>(){
                new Atividade(1),
                new Atividade(2),
                new Atividade(3)      
            }; 

    [HttpGet]
    public IEnumerable<Atividade> Get(){
            return Atividades; //retorna a classe atividade inteira
        }

    [HttpGet("{id}")]

    public Atividade Get(int id){
            return Atividades.FirstOrDefault(ati => ati.Id ==id); //retornar dentro de atividades a atividade com o id igual ao da requisição
        }


    [HttpPost]
    public IEnumerable<Atividade> Post(Atividade atividade){
            
            return Atividades.Append<Atividade>(atividade);
        }

    [HttpPut("{id}")]
    public string Put(int id, Atividade atividade){
            atividade.Id= atividade.Id+1;
            return $"Primeiro método put {id}";
        }

    [HttpDelete("{id}")]
    public string Delete(int id){
            return $"Primeiro método delete {id}";
        }
    
    }
}