var express = require('express'); //Tells node to go get express
var server = express(); //express function returns an object with server methods
let bp = require('body-parser')
var port = 3000;

server.use(express.static(__dirname + '/public')); 


server.listen(port, ()=>{
  console.log('Server is up an running on port: ', port);
});


 server.use(bp.json())
 server.use(bp.urlencoded({
   extended: true
 }))

 server.get('/:name?',(req, res, next) =>{  //question mark means this is optional
     res.send(200).send(`<h1>Michael Smith</h1>`)
 })

server.get('/helloworld', (req,res,next) =>{
    res.send('<h1>Hello World</h1>')
})

