FROM alpine:3.15 

RUN apk update ; \
    apk add -y python3-pip; \
    apk add -y wget; \
    apk add git ; 
    

RUN pip3 install --upgrade pip; \
    python3 -m pip install ansible; 
