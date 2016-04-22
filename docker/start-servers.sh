#! /bin/bash

service ssh start

chmod +x /opt/hadoop/etc/hadoop/hadoop-env.sh
$HADOOP_HOME/etc/hadoop/hadoop-env.sh
$HADOOP_HOME/sbin/start-dfs.sh
$HADOOP_HOME/sbin/start-yarn.sh

/bin/bash