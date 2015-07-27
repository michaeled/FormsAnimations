## A short note

These functions are in beta, and I'm opening this repository because it's been sitting idle for some time. My attention will come back to this library, once other projects are finished.

## What's here?

The current version of Xamarin.Forms (1.4.3.6374) includes the following easing functions that are accessible through the `Easing` static class:

 | Bounce | Cubic | Linear | Sin | Spring
--- | --- | --- | --- | --- | ---
**EaseIn** | &#10003; | &#10003; | n/a | &#10003; | &#10003; 
**EaseOut** | &#10003; | &#10003; | n/a | &#10003; | &#10003;
**EaseInOut** | - | &#10003; | n/a | &#10003; | - 


This library supplements the builtin easing functions, with a few more that are availble through the `MoreEasing` static class.

 | Back | Bounce | Circular | Elastic | Exponential | Quad | Quartic | Quintic | Sin
--- | --- | --- | --- | --- | --- | --- | --- | --- | ---
**EaseOut** | &#10003; | &#10003; | &#10003; | &#10003; | &#10003; | &#10003; | &#10003; | &#10003; | n/a
**EaseIn** | &#10003; | &#10003; | &#10003; | &#10003; | &#10003; | &#10003; | &#10003; | &#10003; | n/a
**EaseInOut** | &#10003; | &#10003; | &#10003; | - | &#10003; | &#10003; | &#10003; | &#10003; | n/a
**EaseOutIn** | &#10003; | &#10003; | - | - | - | - | - | - | n/a
**Dampened** | - | - | - | - | - | - | - | - | &#10003;

## Reference

These functions are an adaption of [Robert Penner's easing functions](http://robertpenner.com/easing/).
[Jesús Gollonet's](https://github.com/jesusgollonet/processing-penner-easing) work was also referenced.
