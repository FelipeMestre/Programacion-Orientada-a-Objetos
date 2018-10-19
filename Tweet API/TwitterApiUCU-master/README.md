# TwitterApiUCU
Api para publicar en twitter de la UCU

Para utilizar esta libreria se debera agregar una referencia a su proyecto y luego invocar el siguiente código:

```c#
var twitter = new TwitterApi(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
twitter.Tweet("This is once again, another tweet").Wait();
```

Las credeciales podran ser descargadas de Webasignatura
