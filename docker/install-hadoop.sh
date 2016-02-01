#! /bin/bash

#hadoop pre-reqs
apt-get update
apt-get install -y ssh rsync

#hadoop 2.7.1
wget --quiet http://mirrors.ukfast.co.uk/sites/ftp.apache.org/hadoop/common/hadoop-2.7.2/hadoop-2.7.2.tar.gz
tar xzf hadoop-2.7.2.tar.gz -C /opt/
ln -s /opt/hadoop-2.7.2 /opt/hadoop
rm hadoop-2.7.2.tar.gz

#setup  folders
/opt/hadoop/bin/hdfs dfs -mkdir /tmp
/opt/hadoop/bin/hdfs dfs -mkdir -p /user/root
/opt/hadoop/bin/hdfs dfs -chmod g+w /tmp
/opt/hadoop/bin/hdfs dfs -chmod g+w /user/root