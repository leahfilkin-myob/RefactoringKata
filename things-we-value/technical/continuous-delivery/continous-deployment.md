# Continous Deployment  

### Definition

Continuous deployment is a software development practice in which every code change goes through the entire pipeline and is put into production, automatically, resulting in many production deployments every day.

Continuous deployment is: 
- an extension of continuous integration. The objectives of CI are: 
    1- minimizing the duration and effort required by each integration episode
    2- being able to deliver a product version suitable for release at any moment
- aiming at minimizing lead time which is the amount of time a work item takes from the beginning to the end of the workflow.
- the time elapsed between development writing one new line of code and this new code being used by live users, in production.

To achieve continuous deployment, the team relies on infrastructure that automates and instruments the various steps leading up to deployment, so that after each integration successfully meeting these release criteria, the live application is updated with new code.

Instrumentation is needed to ensure that any suggestion of lowered quality results in aborting the deployment process, or rolling back the new features, and triggers human intervention.

#### What is the difference between continus Delivery  and continus Deployment?
With **Continuous Delivery** your software is always release-ready, yet the timing of when to push it into production is a business decision, and so the final deployment is a manual step. With **Continuous Deployment**, any updated working version of the application is automatically pushed to production. Continuous Deployment mandates Continuous Delivery, but the opposite is not required.

### Blog posts to read
[Continuous Deployment](https://www.agilealliance.org/glossary/continuous-deployment)
[Lead Time](https://www.agilealliance.org/glossary/lead-time "Lead Time")
[Continuous Integration](https://www.agilealliance.org/glossary/continuous-integrationhttp:// "Continuous Integration")
[Continuous Delivery Vs. Continuous Deployment](https://puppet.com/blog/continuous-delivery-vs-continuous-deployment-what-s-diff "Continuous Delivery Vs. Continuous Deployment")
[https://www.atlassian.com/continuous-delivery/ci-vs-ci-vs-cd](https://www.atlassian.com/continuous-delivery/ci-vs-ci-vs-cd)

### Books to read
Continuous Delivery Reliable Software Releases Through Build, Test, And Deployment Automation by Jez Humble and David Farley ([more info](https://martinfowler.com/books/continuousDelivery.html "more info"))
