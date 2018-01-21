# Test Pyramid
Mike Cohn is credited with having developed the concept of the *test pyramid*.  It was originally called the *test automation pyramid* as automation is its focus.

It is a visualisation of where to direct test effort in order to maximise test creation and maintenance efficiencies as well as test reliability.

![Test Pyramid](http://james-willett.com/wp-content/uploads/2016/05/TestPyramid.png)

Those tests towards the top are considered slower to write and execute, and most fragile.  Those tests towards the bottom are faster to write and execute, and most reliable.

Consequently the pyramid serves as a *test planning reminder* that we should most invest in those towards the bottom and avoid those towards the top unless sufficient confidence in the correctness of the software requires it.

### On time spent testing
It is a norm for testing to constitute roughly _at least 1/3_ of codification effort, with operations and source code contributions constituting the rest.  Some claim that [testing consumes 80% of development effort](http://galorath.com/blog/software-project-failure-costs-billions-better-estimation-planning-can-help), so it pays to understand how to contribute and sustain tests most efficiently.  The test pyramid helps here.

## Blog posts to read
- [Test pyramid introduction](https://martinfowler.com/bliki/TestPyramid.html)
- [The original thinking of Mike Cohn](https://www.mountaingoatsoftware.com/blog/the-forgotten-layer-of-the-test-automation-pyramid)

## More advanced stuff
- [Test pyramid antipatterns explained](https://medium.com/prismapp/prisms-testing-pyramid-99aa6dcf471a)
- [Think in scales and risk, not just the pyramid](https://www.joecolantonio.com/2015/12/09/why-the-testing-pyramid-is-misleading-think-scales)
