FROM java:7
MAINTAINER Elton Stoneman <elton@sixeyed.com>

ENV JAVA_HOME=/usr
ENV HADOOP_HOME=/opt/hadoop

RUN mkdir /hadoop-setup
WORKDIR /hadoop-setup

ADD install-hadoop.sh /hadoop-setup/
RUN ./install-hadoop.sh
ADD ./conf /opt/hadoop/etc/hadoop/

ADD ./ssh/ssh.config /root/.ssh/config
ADD ./ssh/setup-ssh.sh /hadoop-setup/
RUN ./setup-ssh.sh

# HDFS & YARN
EXPOSE 22
EXPOSE 50070
EXPOSE 9000
EXPOSE 8088

ENV PATH=$PATH:/opt/hadoop/bin

# run servers:
ADD start-servers.sh /opt/hadoop/bin/
CMD /opt/hadoop/bin/start-servers.sh