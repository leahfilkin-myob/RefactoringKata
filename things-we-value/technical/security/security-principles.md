# Security Principles  

## AWS

The AWS cloud platform operates on a [shared responsibility model](https://aws.amazon.com/compliance/shared-responsibility-model/). This means that we are still responsible for security within our cloud, just as we would be if we were using an on-site data centre.

The [principle of least privilege](https://en.wikipedia.org/wiki/Principle_of_least_privilege) should be applied where appropriate. That is do not give blanket access - instead, invert the model such that access is not allowed by default and must be allowed.

It is in this spirit that MYOB enabled some rules in [AWS Config](https://aws.amazon.com/config/) which continuously monitor and assess the resources within our AWS accounts. Resources which are configured in violation of these rules are automatically flagged as `noncompliant`.


### Responding to an alert

Notifications for `noncompliant` resources within FMA AWS accounts will be sent to the `#fma-security-alerts` Slack channel and should be fixed as soon as possible.

Acknowledge the alert so that others know you are looking into it. This can be done using a :eyes: reaction on the Slack message. If you can identify the owner, mention them on the Slack message so they are aware of the alert.

Log into the AWS account mentioned in the alert. Fix the `noncompliant` resource. If it belongs to you or is a shared service (e.g. fma-dashboard), you can fix the vulnerability yourself with any help you need from other proteges, mentors, or specialists.  Otherwise, tag the owner so that they know they need to fix it.

Once fixed, use an appropriate reaction (such as :heavy_check_mark:) on the Slack message to show that the vulnerability has been addressed.

Some common vulnerabilities are described below. If you need help with fixes, hit up your fellow proteges, `#svc-security`, or `#oa-support` for guidance. You can also refer to [the documentation](https://myobconfluence.atlassian.net/wiki/spaces/BPO/blog/2020/07/23/1485472426/AWS+Config) supplied by the MYOB team which manages AWS Config rules.

### SecurityGroupOpenToUnauthorizedPorts

A commonly `noncompliant` resource is a `security group` which exposes inbound traffic from unauthorised ports. This is an issue for a few different reasons. Allowing public access means any hacker that compromises your instance can then use it to try and pivot through other AWS machines and into things they definitely shouldn’t have access to. They could also use it for cryptocurrency mining, bulk spamming emails, and much much more.

If we want to connect to an EC2 instance using `ssh`, we must allow inbound traffic to port `22`. Instead of allowing all `ssh` traffic from all IPv4 addresses (i.e. `0.0.0.0/0`), we can specify only the necessary addresses. For example, we could allow traffic only from certain [MYOB IP addresses](https://myobconfluence.atlassian.net/wiki/spaces/IS/pages/48564083/Public+IP+Subnets) and Buildkite agents.
