using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace ManualDi
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ValueService valueService;
        private readonly ThreadLocal<Random> random =
            new ThreadLocal<Random>(() => new Random());

        public ValuesController(ValueService valueService)
            => this.valueService = valueService;

        [HttpGet]
        public IEnumerable<ValueRecord> Get() => valueService.Get();

        [HttpGet("{id}")]
        public ValueRecord Get(int id) => valueService.Get(id);

        [HttpPost]
        public void Post([FromBody]ValueRecord value)
            => valueService.Update(random.Value.Next(), value);

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ValueRecord value)
            => valueService.Update(id, value);

        [HttpDelete("{id}")]
        public void Delete(int id) => valueService.Delete(id);
    }
}
