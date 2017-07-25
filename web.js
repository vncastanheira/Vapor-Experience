var express = require('express')
var app = express()
var path = require('path');

app.use(express.static('Web'));
app.get('/', function(req, res) {
    res.sendFile(path.join(__dirname + '/Build/Web/index.html'));
});

app.listen(3000, function () {
  console.log('Unity app listening on port 3000!')
})