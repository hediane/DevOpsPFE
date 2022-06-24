FROM alpine:3.15 

RUN apt-get check-update; \
    apt-get install -y python3-pip; \
    apt-get install -y wget; \
    apt-get install git ; \
    apt-get clean all

RUN pip3 install --upgrade pip; \
    python3 -m pip install ansible; 
