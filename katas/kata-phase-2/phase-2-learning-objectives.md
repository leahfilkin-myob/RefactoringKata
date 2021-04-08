
# Learning Objectives

There are lots of learning objectives so don't tackle them all at once! The objectives are self-contained and designed to be addressed one at a time. Pick one at a time and have a flexible roadmap. You should aim to finish all Level 3 objectives before tackling any level 4 objectives.

Higher levels of learning objectives build on lower levels. However you should be free to jump around different areas to best suit your desired learning path. Some objectives require you to have completed other specific objectives - when this is the case it is explicitly mentioned in the description.

The descriptions include specific technologies that are most commonly used in MYOB. These are the recommended as default choices, however you and your mentors are free to choose any other technologies should they better suit your needs.

You should complete up to Level 3 of each learning area. The 4th levels are optional stretch goals.

## API Design

### Level 1

> <i>Can describe what an API is and what can help make it successful. Has built something that responds to a request locally. Some form of documentation exists.</i>

It's important to understand that to build a successful API we need to go beyond just the technical implementation. We need to offer something that's useful, stable, secure, and easy to use. We need to treat users as customers, and our API as a product.

We will be leveraging industry standard tools to quickly create a usable API. At MYOB the most common server-side technology is C#/dotnetcore. The first iteration can be anything that can be accessed locally, such as a GET endpoint that returns "Hello World".

Make sure that this endpoint has some form of documentation. This could be some simple instructions in your README.

Resources:
* https://www.thoughtworks.com/radar/techniques/apis-as-a-product
* https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-5.0
* https://www.linkedin.com/learning/building-web-apis-with-asp-dot-net-core-3

### Level 2

> <i>Can describe the basics of JSON and REST. Understands standard best practices for RESTful API design. The project supports basic operations and this is documented.</i>

At MYOB we most commonly see REST over HTTPS using JSON. 

By following industry stndard best practices we can take big steps towards making our APIs easier to use for our consumers.

Your project should support Create/Read/Update/Delete operations. We strongly suggest using REST with JSON as this is widely used across MYOB. The operations should be documented.

* https://en.wikipedia.org/wiki/JSON
* https://en.wikipedia.org/wiki/Representational_state_transfer
* https://www.linkedin.com/learning/learning-rest-apis/
* https://code.tutsplus.com/tutorials/a-beginners-guide-to-http-and-rest--net-16340

### Level 3

> <i>Can articulate benefits of following industry stndards for documentation. Project handles all common use-cases including errors. These are documented following industry standards.</i>

Handling and providing good experiences around errors is also an important part of a good API. You should make sure that error cases are handled in a way consumers expect and also included documentation.

At MYOB the most common REST specification is OpenAPI, and Swagger is the tool typically used to help build documentation. You should use a tool such as Swagger to build the API documentation. 

* https://developer.mozilla.org/en-US/docs/Web/HTTP/Status
* https://http.cat
* https://httpstatusdogs.com
* https://www.openapis.org/faq
* https://swagger.io/
* https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0

### Level 4

> <i> Can describe strategies for evolving APIs while minimising customer impact. Has updated project API in such a manner. </i> 

When evolving an API we often discover that we want to change the shape of our interfaces in an incompatible way. There are strategies around this, such as versioning or expand-contract. 

You should change your API to support first and last names instead of a single name field. This should be done in a way that minimises customer impact.

* https://martinfowler.com/bliki/ParallelChange.html
* https://restfulapi.net/versioning/

## Continuous Integration

### Level 1

> <i>Can explain containerisation and why it's beneficial. The project can be run as a container.</i>

Containerisation allows us to build and run our software in a consistent environment on any type of machine. At MYOB, Docker is the standard container technology we use.

You should build a container image for your project and be able to run it from the image.

* https://docs.docker.com/get-started/overview/
* https://docs.docker.com/get-started/  

### Level 2

> <i>Can explain continuous integration and why it is used. Demonstrates a working continuous integration pipeline that runs tests and builds the project.</i>

Continuous integration helps give us confidence that our software is working, provides fast feedback, and allows us to respond to problems faster. This is achieved through services that can automatically test and build our software.

The standard build tool used at MYOB is Buildkite. You should run your tests and build your project whenever you commit to your code repository.

* https://www.martinfowler.com/articles/continuousIntegration.html
* https://hello.hub.myob.com/auto/buildkite.html

### Level 3

> <i>Can explain what artefact repositories are and their benefits. The project pushes images to an artefact repository only if the tests pass and build succeeds.</i>

Container images are stored in artefact repositories so they can be used by other machines. The standard artefact repository we use at MYOB is cloudsmith.

You should update your build pipeline so that it pushes your built images to an artefact repository, but only when your tests and build pass.

* https://hello.hub.myob.com/arts/cloudsmith.html

### Level 4

> <i>Can articulate the value of having clearly defined and fast build pipelines. Project has clearly defined build steps with seperated concerns, and is optimised to build as quickly as possible.</i>

Having clearly defined build steps with separations of concerns allows you to quickly identify the cause of build failures.

Pipelines can be optimised through parallelisation and containers can be optimised through creating smaller images and refining container build steps.

You should improve your build process so that your pipeline has clearly defined steps with separated concerns. You should optimise your pipeline structure and container building.

* https://docs.docker.com/develop/develop-images/dockerfile_best-practices/
* https://buildkite.com/docs/pipelines

## Continuous Delivery/Deployment

### Level 1

> <i>Can explain the benefits of using a service to run your containers. Can get the project running in a service manually.</i>

You should complete Continuous Integration Level 1 prior to attempting this.

There are many technologies and services that can run or orchestrate containers. The default technology at MYOB is Jupiter, which is a platform composing of Kubernetes and several other technologies.

If you are using MYOB's standard technology stack, you can run a Docker container in Jupiter manually. The URL of your Docker container image can be used to manually deploy a Pod in Jupiter through the Jupiter Kubernetes dashboard.

You should deploy your project and run it in a service. It doesn't need to be accessible from the internet, but you can verify it's working via shell access to the running container.

* https://en.wikipedia.org/wiki/IT_infrastructure
* https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
* https://docs.jupiter.myob.com/what-and-why/why.html
* https://docs.jupiter.myob.com/what-and-why/what-is-jupiter.html

### Level 2

> <i>Can articulate what the various components of your infrastructure achieve. Project can be deployed from a configuration file via the command line.</i>

Infrastructure is the backbone that runs all the software we make. You should understand what the various components of your project achieve. 

For Jupiter you can create configuration files for your infrastructure that can be deployed via the command line. 

You should document what you are using the various components of your infrastructure for, and be able to deploy your project via the command line.

* https://docs.jupiter.myob.com/basics/getting-started.html

### Level 3

> <i>Can articulate the benefits of having infrastructure as code. Project is deployed from a build pipeline using infrastructure as code concepts.</i>

Having as much as possible of your infrastructure in version control allows you easily recreate your current, or any previous state of your infrastructure with ease. This allows us to deliver our software and its environment quickly and with confidence.

Your project should be deployed as part of your build pipeline.

This learning objective requires Continuous Integration Level 2.

* https://docs.jupiter.myob.com/basics/deployment-with-buildkite.html

### Level 4

> <i>Articulates the full continuous integration, continuous deployment and continuous delivery concepts and how it impacts the customer. Has implemented automation to deploy software to multiple environments (eg “sit” and “prod”) and can explain the processes used.</i>

Ultimately CI/CD is about giving us the ability to delivery quality software to our customers quickly and with more confidence. 

Supporting multiple environments gives us the flexibility to test things that we wouldn't be able to in a production environment.

At MYOB we commonly use ktmpl to support multiple environments without duplicating all of our configuration files.

* https://www.atlassian.com/continuous-delivery/principles/continuous-integration-vs-delivery-vs-deployment
* https://docs.jupiter.myob.com/basics/templating.html


## Security

### Level 1

> <i>Can articulate the importance of security and how it can impact the safety and livelihood of our customers and employees.
Can explain the concepts of threats, vulnerabilities and risks. Can describe how risks are reduced by improving our application security as well as our ability to respond to security incidents.</i>

A security breach may expose personal data of our customers to attackers. As an accounting company MYOB holds a large quantity of sensitive personal and business information. In the wrong hands such information can have material impacts on our customers financial, physical and mental wellbeing. It can also cause irreversible brand damage to the MYOB brand.

Understanding the concepts of threats, vulnerabilities and risks helps us have objective discussions about how to identify, prioritise and remediate security issues. 

At MYOB our appsec team helps us build secure systems, and our secops team helps us respond to security incidents. We also have a GRC (Governance, Risk and Compliance) team to help us manage risks and meet our various obligations.

* https://en.wikipedia.org/wiki/Application_security
* https://myobconfluence.atlassian.net/wiki/spaces/security/overview

### Level 2

> <i>Knows resources (such as OWASP) that describe common security concerns applicable to developers. Has checked top risks against project and documented any concerns.
Can describe risks associated with handling secrets and ways of mitigating them.</i>

There are many resources available to help us build secure systems. OWASP is one commonly referenced security resource that has a multitude of beneficial information, most famously the OWASP Top 10.

You should review you application against common security risks, such as those outlined in the OWASP Top 10 and document any issues.

Safely handling "secrets" is critical to system security. Cloud providers typically provide secret management services, and the MYOB Jupiter platform (Kubernetes) also has secret management capabilities.

* https://owasp.org/www-project-top-ten/
* https://kubernetes.io/docs/concepts/configuration/secret/
* https://github.com/MYOB-Technology/General_Developer/blob/main/things-we-value/technical/security/managing-secrets.md

### Level 3

> <i>Has applied some form of security analysis in build pipeline and is aware of other techniques to actively identify vulnerabilities.
Has implemented proper secret management in the project.</i>

Static security analysis is an easy way to identify common security vulnerabilities by analysing our codebases. At MYOB we use SonarQube as our recommended static security analysis tool.

You should implement SonarQube as part of you build pipeline and implement proper secret management 

This learning objective requires Continuous Deployment/Delivery Level 2.

* https://myobconfluence.atlassian.net/wiki/spaces/security/pages/1008635265/SonarQube

### Level 4

> <i>Understands where security lives at each stage of the SDLC and how/when most teams interact with it. Has retroactively completed a threat model for the project.</i>

Security needs to be incorporated throughout our software delivery lifecycle. Appsec services and tools should be leveraged from planning stages through to after deployment.

You should run a threat modelling exercise on your project.

* https://myobconfluence.atlassian.net/wiki/spaces/security/pages/854327774/Security+Services
