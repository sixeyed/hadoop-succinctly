FROM java:7
MAINTAINER Elton Stoneman <elton@sixeyed.com>

ENV JAVA_HOME=/usr
ENV HADOOP_HOME=/opt/hadoop

RUN mkdir /hadoop-setup
WORKDIR /hadoop-setup

ADD install-hadoop.sh /hadoop-setup/
RUN ./install-hadoop.sh
ADD ./conf /opt/hadoop/etc/hadoop/

#RUN sed s/HOSTNAME/localhost/ /opt/hadoop/etc/hadoop/core-site.xml.template > /opt/hadoop/etc/hadoop/core-site.xml

ADD ./ssh/ssh.config /root/.ssh/config
ADD ./ssh/setup-ssh.sh /hadoop-setup/
RUN ./setup-ssh.sh

ADD setup-hdfs.sh /hadoop-setup/
RUN ./setup-hdfs.sh

#TODO - rationalise
# Hdfs ports
EXPOSE 50010 50020 50070 50075 50090 8020 9000
# Mapred ports
EXPOSE 19888
#Yarn ports
EXPOSE 8030 8031 8032 8033 8040 8042 8088
#Other ports
EXPOSE 49707 2122

ENV PATH=$PATH:/opt/hadoop/bin

# run servers:
ADD start-servers.sh /opt/hadoop/bin/
CMD /opt/hadoop/bin/start-servers.sh