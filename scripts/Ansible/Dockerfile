FROM alpine:3.15 

RUN apt check-update; \
    apt install -y python3-pip; \
    apt install -y wget; \
    apt install git ; \
    apt clean all

RUN pip3 install --upgrade pip; \
    python3 -m pip install ansible; 
