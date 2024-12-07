Delivered-To: nghia562001@gmail.com
Received: by 2002:a05:6802:1e8e:b0:577:af9e:7226 with SMTP id er14csp156693ocb;
        Fri, 6 Dec 2024 19:31:58 -0800 (PST)
X-Google-Smtp-Source: AGHT+IEjO8MNfvCD1CgG2905uFa3+m5sEJcVoRB4+4JXrpJIwX3FLZnUOClEfNLMuVAB1ZgUB3Ld
X-Received: by 2002:a05:620a:19a6:b0:7b1:4579:80ea with SMTP id af79cd13be357-7b6bcb65738mr757440485a.60.1733542318674;
        Fri, 06 Dec 2024 19:31:58 -0800 (PST)
ARC-Seal: i=1; a=rsa-sha256; t=1733542318; cv=none;
        d=google.com; s=arc-20240605;
        b=TH+wWwWj8gZCmr/t9DCZxyrXh7W6UAKnNYZ2VUN/iKBEIr+WnfpRsFMLFMH8FU0N2i
         2+w3uXrcV+19JFwmNaaat9eUZ0muvQKbtcH/lyzNyAHOZfp0CmDt65iNkSor19ZMeA2X
         kuJgtmh6xtlL2bOWf647tf+mcnR9be3L5HvxWTWZPbzXAb9Qd7PPiFBRzfu+mqcVzVFT
         RdVOEsBtq/17pnP3bluXoR8gf4T0q8VblGd/jbRjI7uFcXFuc6GBDsdEohj5pqe6CKHn
         J7SRlTV8njDG5dej+t7fzRysKhrdYpMpyq6/ceR7/lH20JKd59ZXQXB4fODQi8zP3gOi
         q1dQ==
ARC-Message-Signature: i=1; a=rsa-sha256; c=relaxed/relaxed; d=google.com; s=arc-20240605;
        h=to:list-unsubscribe-post:list-unsubscribe:reply-to:subject
         :message-id:mime-version:from:date:dkim-signature:dkim-signature;
        bh=Xd8P3a2Ax2orv+1W6E7r0FUyS52jVIEyenP9AYErkxY=;
        fh=1La/Gy9miLDtyf+CpP9v7WM3xSWl4mMMdmsFVj/Ws5U=;
        b=Qr9/Q4wRFOvAz7BU4kucxUZuXppizzAnAzz3aYzuoloPVDlPkD65LWYlc3b2dKM+rW
         xkPBv+eJwvIPS8w8XPqF3MknPX3VrZXGLufnuwzlSZ/sFKrHuQRCfi4RdhNMVWVI+LbD
         GGdcpCdFXccECAtlSWGVLoxqiZELnuHddHE/FukXiMtDrpT7cJPC5b0NGXydf1Fu1pli
         Gyc1oK++DNs773fhUNiw3+NMXaq+QxFgQoXen1xH+1762RuWlYEBBkbnXXtF8nDZzEoT
         JllqwevJa0CDKgr72w+m9Xv1irpIjzf0SJHrJoN7omZPYbkZ7c4gxcHz52DJcQEafqjp
         BKnQ==;
        dara=google.com
ARC-Authentication-Results: i=1; mx.google.com;
       dkim=pass header.i=@marketing.acb.com.vn header.s=pst header.b="Mst/5TSR";
       dkim=pass header.i=@sendgrid.info header.s=smtpapi header.b=wXhdeVyq;
       spf=pass (google.com: domain of bounces+45836307-3204-nghia562001=gmail.com@pst.marketing.acb.com.vn designates 159.183.30.130 as permitted sender) smtp.mailfrom="bounces+45836307-3204-nghia562001=gmail.com@pst.marketing.acb.com.vn";
       dmarc=pass (p=NONE sp=NONE dis=NONE) header.from=marketing.acb.com.vn
Return-Path: <bounces+45836307-3204-nghia562001=gmail.com@pst.marketing.acb.com.vn>
Received: from o1007.ptr4497.marketing.acb.com.vn (o1007.ptr4497.marketing.acb.com.vn. [159.183.30.130])
        by mx.google.com with ESMTPS id 6a1803df08f44-6d8e635792fsi38799086d6.474.2024.12.06.19.31.57
        for <nghia562001@gmail.com>
        (version=TLS1_3 cipher=TLS_AES_128_GCM_SHA256 bits=128/128);
        Fri, 06 Dec 2024 19:31:58 -0800 (PST)
Received-SPF: pass (google.com: domain of bounces+45836307-3204-nghia562001=gmail.com@pst.marketing.acb.com.vn designates 159.183.30.130 as permitted sender) client-ip=159.183.30.130;
Authentication-Results: mx.google.com;
       dkim=pass header.i=@marketing.acb.com.vn header.s=pst header.b="Mst/5TSR";
       dkim=pass header.i=@sendgrid.info header.s=smtpapi header.b=wXhdeVyq;
       spf=pass (google.com: domain of bounces+45836307-3204-nghia562001=gmail.com@pst.marketing.acb.com.vn designates 159.183.30.130 as permitted sender) smtp.mailfrom="bounces+45836307-3204-nghia562001=gmail.com@pst.marketing.acb.com.vn";
       dmarc=pass (p=NONE sp=NONE dis=NONE) header.from=marketing.acb.com.vn
DKIM-Signature: v=1; a=rsa-sha256; c=relaxed/relaxed; d=marketing.acb.com.vn;
	h=content-type:from:mime-version:subject:reply-to:list-unsubscribe:
	list-unsubscribe-post:x-feedback-id:to:cc:content-type:from:subject:to;
	s=pst; bh=Xd8P3a2Ax2orv+1W6E7r0FUyS52jVIEyenP9AYErkxY=;
	b=Mst/5TSRrN8wd/OnCmquFKMUB5u8mfy5CEVSimkocX8CReZ8bdI4J3Rn0pwzuDYpLmKx
	SwxI0N5T8IGMDxTKBinJb01BqEQUKpIoTw0tdE5c7bRKdft7Sit/VjE6Mo/bU4rcwdlb63
	B49mmuJiLmURgm2GViCy4sVoHyMot56wMPblAcA6YbOBZSJ5+bOlbv4YAjFKOTocbb1YWr
	q+ARiCL2yO66Wfy60m0RkHM7VWpV8ZvWfzlIKIo9e4Jw/KTY19DMSFLEqpnJt6dUQ81/c9
	9aqXIxZLO2O6So42oej9mHWAIzVGUXe5v14hWLIRjZD/BfqdyQvpu2im/s8JUtLA==
DKIM-Signature: v=1; a=rsa-sha256; c=relaxed/relaxed; d=sendgrid.info;
	h=content-type:from:mime-version:subject:reply-to:list-unsubscribe:
	list-unsubscribe-post:x-feedback-id:to:cc:content-type:from:subject:to;
	s=smtpapi; bh=Xd8P3a2Ax2orv+1W6E7r0FUyS52jVIEyenP9AYErkxY=;
	b=wXhdeVyqSkzuhSniMn6/a3B97qM8gBvj4NEenDHiiYsaK1gsIbflP4np7P+l6xxkLVwm
	+Lk21FaVrtC7up6HU1/AvH/8n98tbD3Rnw2YBNZmw2vHFJIrf1IzjLt8dZxHfa8jmq5iqX
	I460WqcSUJUFk6EWd/DQifGBqbOdpx2oU=
Received: by recvd-bdd545687-bzmbm with SMTP id recvd-bdd545687-bzmbm-1-6753C1AD-1
	2024-12-07 03:31:57.011762992 +0000 UTC m=+1922992.265202354
Received: from NDU4MzYzMDc (unknown)
	by geopod-ismtpd-4 (SG) with HTTP
	id O63g1AGlT9uJh6dyEOkQeA
	Sat, 07 Dec 2024 03:31:56.998 +0000 (UTC)
Content-Type: multipart/alternative; boundary=b14ac2ee0bc61aca5e46039d5fe228e8500a89e5e220356fd2edc062d849
Date: Sat, 07 Dec 2024 03:31:57 +0000 (UTC)
From: "Ngan Hang A Chau (ACB)" <news@marketing.acb.com.vn>
Mime-Version: 1.0
Message-ID: <O63g1AGlT9uJh6dyEOkQeA@geopod-ismtpd-4>
Subject: =?UTF-8?B?VEjDlE5HIELDgU8gUVVBTiBUUuG7jE5HOg==?= v/v
 =?UTF-8?B?S2jDoWNoIGjDoG5nIGPhuqduIHRo4buxYyBoaeG7h24=?= sinh
 =?UTF-8?B?dHLhuq9jIGjhu41j?=
Reply-To: "Ngan Hang A Chau (ACB)" <news@marketing.acb.com.vn>
List-Unsubscribe: 
 =?us-ascii?Q?=3Chttps=3A=2F=2Fmail=2Euseinsider=2Ecom=2Fuser=2Fv1=2Fscu=2Facb=2Femail=2F8315=2F47D40E?=
 =?us-ascii?Q?A7BD9C496C973A74AE02B0BB3D=3E?=
List-Unsubscribe-Post: List-Unsubscribe=One-Click
X-Feedback-ID: 45836307:SG
X-SG-EID: 
 =?us-ascii?Q?u001=2Eq14=2F5Cls6BKX6tD+dzCbI9eDwOEykuI08YbCfOOzqKy5lI0Q2e91m90Yx?=
 =?us-ascii?Q?P5ggLHts3lz9suNyFDHbw2p3pgHVDr3HjNhN3sA?=
 =?us-ascii?Q?a0D049+CH=2F90KlcC+LfMRBvyof18f3UCXWBah2f?=
 =?us-ascii?Q?gNyvZSAI6EK1op=2FczvZsgcQFHjjUGJFQ9wHwPz2?=
 =?us-ascii?Q?ZdeJCDqCZNqIPwAdYUrtRaEMHgIV9JmZZsXkctC?=
 =?us-ascii?Q?RmfWBOuaatrTSixXyvhvqLguOvtpHE9EbqATV+o?=
 =?us-ascii?Q?GJ0wZyNcJ1IJ=2F1HequE8tj=2FBSQ=3D=3D?=
X-SG-ID: 
 =?us-ascii?Q?u001=2ESdBcvi+Evd=2FbQef8eZF3BrVKSgXmzIWS3rUbD0hfIs0wRxEucC9cJyS1q?=
 =?us-ascii?Q?Q+Ko0kAKp26OCQDpAN5sSuBB6=2Fpb1Q5PNzGGmga?=
 =?us-ascii?Q?S1Ceu8LiV9PLDTzbX2nNWxxfYdHH0vHPGoRFTp1?=
 =?us-ascii?Q?sTe2u1EQSM=2FL3YsPcoYx99C1mNjf3ufxOBtG4+D?=
 =?us-ascii?Q?clK1oxHU=2Fw=2FdDdiAh4SCMW52qYug7ZXxEfRxTxx?=
 =?us-ascii?Q?h98B5koh5Lfe9zFDeFQTKwkDfBUEPc5Kurahvnm?=
 =?us-ascii?Q?d7zqXQ1SXOXLCHlDlwFFKksPfZFYCFoCGUbCsBD?=
 =?us-ascii?Q?65hwTyfG2pyAM5zutVuZ0zzqBGKIuAdDLkdBhyA?=
 =?us-ascii?Q?kKp2=2FBJDb4qkCp6UXAZ7VSM1HB1A14PoL=2F3rClR?=
 =?us-ascii?Q?ogK9s9M9cFBRPRUAYJTbxQsRj8mwVYGyHKDqvsq?=
 =?us-ascii?Q?JtzS1n4ik+2OSRsYvv8cWC7KGXhTuRf9gGknOH4?=
 =?us-ascii?Q?pA1ojNqTpscApWAXbqYdzq2mt=2FnHUBIelag3K7n?=
 =?us-ascii?Q?EchIut4d+qAYTB632yjdC9NBan+d7UK3kbq5ZHu?=
 =?us-ascii?Q?glFv3hG6mFd0aw8gg+sDuL0WtDwaPG6=2FnCUKXpU?=
 =?us-ascii?Q?kyZV9lOpYHZWurdZBbskYxpmTKnQcXJEmqDqM2e?=
 =?us-ascii?Q?QOr7oV0B1s35d3opp816tbNkDpNAJ+vj2Vpwhso?=
 =?us-ascii?Q?+xrPLUTbTAmEzFS9agvziT+N6ch0fjFWI5WbyBs?=
 =?us-ascii?Q?jUu+M5ri3rtkkiUePVcqhXA31DL+OxvBOem8+nH?=
 =?us-ascii?Q?E7RonjIwY0MSfKZKDnYWUZs7OIxdDyfrAV4Gdpq?=
 =?us-ascii?Q?dw5IECLlxmzcKEwL6q1SkN5KtTRABQDlC36Gwss?=
 =?us-ascii?Q?1ofvI0X6gstjF=2F49QH8jKoBrqajNJ=2FX2iqoRihS?=
 =?us-ascii?Q?dBPRMhj3tWZW12s27+gMM3OxNYgTTHlt3W+Q4vA?=
 =?us-ascii?Q?FP3f+Ghbk4s5T71vndhp?=
To: nghia562001@gmail.com
X-Entity-ID: u001.fLiEgqa46YjpoVGnJqjpcw==

--b14ac2ee0bc61aca5e46039d5fe228e8500a89e5e220356fd2edc062d849
Content-Transfer-Encoding: quoted-printable
Content-Type: text/plain; charset=utf-8
Mime-Version: 1.0

<!--=E2=84=A2--><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//=
EN" "https://u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QZHyc7EIDeNDrxcQ=
QmuGc7h9-2FRmuU1RqTChUJK6k-2FBTQXzKkf9WKuQ66m-2BKzleMFRAcJCWxyTsm6rrV3unDUf=
VvdxLFPYld1jRw-2Fj5BUOM8-3D1pZ9_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIA=
RgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfE=
Ctjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEho=
DZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M=
7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRur=
LbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQ=
fWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JS=
PZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0=
qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2=
B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9t=
aE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf=
6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqw=
RqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwdByQyV-2FeXPXlUiF2GPXfnluykgbSW12LF2=
iSQMT0rWIW0QY9O3lt-2BF9ArM8MsQ4JPNMrRNj-2FKrL57Q8-2FvhhcWF1q3ZHmexWJys7BFEb=
d3iU-2Fk-2Bh18cpFwfuh2eE5Z8458g3o8n0zNzNXXhThQZV8armJoGyVu-2Bx1TfoOlI5toKSo=
NNjfaqfMrUx1f7-2FfDWGzgUbtA2QNduXjy4NYX4xkqC6cRD6t-2BIIk9wUDnnOXght><html x=
mlns:o=3D"urn:schemas-microsoft-com:office:office" xmlns=3D"https://u458363=
07.ct.sendgrid.net/ls/click?upn=3Du001.QZHyc7EIDeNDrxcQQmuGc7CPgg8SdKe9YUrn=
HyknFH52qIGPYg7WVQWKfMmrK5vkylC6_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjI=
ARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqf=
ECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEh=
oDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0=
M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRu=
rLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfo=
QfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7J=
SPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF=
0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-=
2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9=
taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vEr=
f6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWq=
wRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwd64wLn85nTEEJkSaIb1e-2F-2BcnCKv7TUn=
wmL-2BR5mJVH3G2L-2F4gP-2BUUVvSEAVauwQOAjTh085UjU6mmjhB5xGMnBD3nrd9ZMDSN1Zrj=
ue0b6ObxeL4fE-2BLc3yqjIhvuECC8ggr1-2BydjEehm84ZwZaXsLf6u122mae8P3haQ8y3pjsO=
sM3863uAjCzhUECH8Ye71wtS2q9TjQydzlnezfLxb9GrGjXdUWO6NOSUU2UzLiXL lang=3D"un=
d" style=3D"padding:0;Margin:0"><head><meta http-equiv=3D"Content-Type" con=
tent=3D"text/html; charset=3DUTF-8"/><meta charset=3D"UTF-8"/><meta content=
=3D"width=3Ddevice-width, initial-scale=3D1" name=3D"viewport"/><meta name=
=3D"x-apple-disable-message-reformatting"/><meta http-equiv=3D"X-UA-Compati=
ble" content=3D"IE=3Dedge"/><meta content=3D"telephone=3Dno" name=3D"format=
-detection"/><title></title> <!--[if (mso 16)]><style type=3D"text/css">a{t=
ext-decoration:none} </style><![endif]--><!--[if gte mso 9]><style>sup{font=
-size:100% !important}</style><![endif]--><!--[if gte mso 9]><style>sup{fon=
t-size:100% !important}</style><![endif]--><!--[if gte mso 9]><style>sup{fo=
nt-size:100% !important}</style><![endif]--><!--[if gte mso 9]><style>sup{f=
ont-size:100% !important}</style><![endif]--><!--[if gte mso 9]><style>sup =
{ font-size: 100% !important; }</style><![endif]--><style type=3D"text/css"=
>#outlook a { padding:0;}.ExternalClass { width:100%;}.ExternalClass, .Exte=
rnalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .=
ExternalClass div { line-height:100%;}.es-button { mso-style-priority:100!i=
mportant; text-decoration:none!important;}a[x-apple-data-detectors] { color=
:inherit!important; text-decoration:none!important; font-size:inherit!impor=
tant; font-family:inherit!important; font-weight:inherit!important; line-he=
ight:inherit!important;}.es-desk-hidden { display:none; float:left; overflo=
w:hidden; width:0; max-height:0; line-height:0; mso-hide:all;}@media only s=
creen and (max-width:600px) {p, ul li, ol li, a { line-height:150%!importan=
t } h1, h2, h3, h1 a, h2 a, h3 a { line-height:120%!important } h1 { font-s=
ize:30px!important; text-align:center } h2 { font-size:26px!important; text=
-align:center } h3 { font-size:20px!important; text-align:center } .es-head=
er-body h1 a, .es-content-body h1 a, .es-footer-body h1 a { font-size:30px!=
important } .es-header-body h2 a, .es-content-body h2 a, .es-footer-body h2=
 a { font-size:26px!important } .es-header-body h3 a, .es-content-body h3 a=
, .es-footer-body h3 a { font-size:20px!important } .es-menu td a { font-si=
ze:13px!important } .es-header-body p, .es-header-body ul li, .es-header-bo=
dy ol li, .es-header-body a { font-size:16px!important } .es-content-body p=
, .es-content-body ul li, .es-content-body ol li, .es-content-body a { font=
-size:16px!important } .es-footer-body p, .es-footer-body ul li, .es-footer=
-body ol li, .es-footer-body a { font-size:16px!important } .es-infoblock p=
, .es-infoblock ul li, .es-infoblock ol li, .es-infoblock a { font-size:12p=
x!important } *[class=3D"gmail-fix"] { display:none!important } .es-m-txt-c=
, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 { text-align:center!import=
ant } .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es-m-txt-r h3 { text-al=
ign:right!important } .es-m-txt-l, .es-m-txt-l h1, .es-m-txt-l h2, .es-m-tx=
t-l h3 { text-align:left!important } .es-m-txt-r img, .es-m-txt-c img, .es-=
m-txt-l img { display:inline!important } .es-button-border { display:block!=
important } a.es-button, button.es-button { font-size:16px!important; displ=
ay:block!important; padding-left:0px!important; padding-right:0px!important=
 } .es-btn-fw { border-width:10px 0px!important; text-align:center!importan=
t } .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .es-left, .es-right { =
width:100%!important } .ext-product-button, .ext-product-price p, .ext-prod=
uct-original-price p { width:100%!important } .ext-product-button a { max-w=
idth:100%!important } .ext-product-name.ins-vertical p { height:90px!import=
ant; overflow:hidden!important; word-break:break-all!important; font-size:1=
2px!important; line-height:150%!important } .ext-product-name.ins-vertical =
{ height:100px!important } .ext-product-name p { height:unset!important; wi=
dth:100%!important; overflow:hidden!important; font-size:16px!important; li=
ne-height:150%!important } .ext-product-name { height:unset!important } .ex=
t-product-price.ins-vertical p { overflow:hidden!important; word-break:brea=
k-all!important; height:36px!important; font-size:12px!important; line-heig=
ht:150%!important } .ext-product-price.ins-vertical { height:56px!important=
 } .ext-product-original-price.ins-vertical p { overflow:hidden!important; =
word-break:break-all!important; height:36px!important; font-size:12px!impor=
tant; line-height:150%!important } .ext-product-original-price.ins-vertical=
 { height:56px!important } .ext-ins-attr.ins-vertical p { overflow:hidden!i=
mportant; word-break:break-all!important; height:54px!important; font-size:=
12px!important; line-height:150%!important; width:100%!important } .ext-ins=
-attr.ins-vertical { height:74px!important } .ext-product-button a.ins-vert=
ical { word-break:break-all!important; font-size:12px!important } .ext-prod=
uct-image.ins-vertical { height:unset!important } td.esdev-mso-td.ins-verti=
cal { vertical-align:bottom!important } .es-content table, .es-header table=
, .es-footer table, .es-content, .es-footer, .es-header { width:100%!import=
ant; max-width:600px!important } .es-adapt-td { display:block!important; wi=
dth:100%!important } .adapt-img { width:100%!important; height:auto!importa=
nt } .es-m-p0 { padding:0!important } .es-m-p0r { padding-right:0!important=
 } .es-m-p0l { padding-left:0!important } .es-m-p0t { padding-top:0!importa=
nt } .es-m-p0b { padding-bottom:0!important } .es-m-p20b { padding-bottom:2=
0px!important } .es-mobile-hidden, .es-hidden { display:none!important } .e=
s-desk-hidden { display:table-row!important; width:auto!important; overflow=
:visible!important; float:none!important; max-height:inherit!important; lin=
e-height:inherit!important } .es-desk-menu-hidden { display:table-cell!impo=
rtant } table.es-table-not-adapt, .esd-block-html table { width:auto!import=
ant } table.es-social { display:inline-block!important } table.es-social td=
 { display:inline-block!important } .h-auto { height:auto!important } .es-m=
-p5 { padding:5px!important } .es-m-p5t { padding-top:5px!important } .es-m=
-p5b { padding-bottom:5px!important } .es-m-p5r { padding-right:5px!importa=
nt } .es-m-p5l { padding-left:5px!important } .es-m-p10 { padding:10px!impo=
rtant } .es-m-p10t { padding-top:10px!important } .es-m-p10b { padding-bott=
om:10px!important } .es-m-p10r { padding-right:10px!important } .es-m-p10l =
{ padding-left:10px!important } .es-m-p15 { padding:15px!important } .es-m-=
p15t { padding-top:15px!important } .es-m-p15b { padding-bottom:15px!import=
ant } .es-m-p15r { padding-right:15px!important } .es-m-p15l { padding-left=
:15px!important } .es-m-p20 { padding:20px!important } .es-m-p20t { padding=
-top:20px!important } .es-m-p20r { padding-right:20px!important } .es-m-p20=
l { padding-left:20px!important } .es-m-p25 { padding:25px!important } .es-=
m-p25t { padding-top:25px!important } .es-m-p25b { padding-bottom:25px!impo=
rtant } .es-m-p25r { padding-right:25px!important } .es-m-p25l { padding-le=
ft:25px!important } .es-m-p30 { padding:30px!important } .es-m-p30t { paddi=
ng-top:30px!important } .es-m-p30b { padding-bottom:30px!important } .es-m-=
p30r { padding-right:30px!important } .es-m-p30l { padding-left:30px!import=
ant } .es-m-p35 { padding:35px!important } .es-m-p35t { padding-top:35px!im=
portant } .es-m-p35b { padding-bottom:35px!important } .es-m-p35r { padding=
-right:35px!important } .es-m-p35l { padding-left:35px!important } .es-m-p4=
0 { padding:40px!important } .es-m-p40t { padding-top:40px!important } .es-=
m-p40b { padding-bottom:40px!important } .es-m-p40r { padding-right:40px!im=
portant } .es-m-p40l { padding-left:40px!important } }@media screen and (ma=
x-width:384px) {.mail-message-content { width:414px!important } }</style> <=
!--[if gte mso 9]> <xml> <o:OfficeDocumentSettings> <o:AllowPNG></o:AllowPN=
G> <o:PixelsPerInch>96</o:PixelsPerInch> </o:OfficeDocumentSettings> </xml>=
 <![endif]--></head> <body><span style=3D"display:none !important; visibili=
ty:hidden; mso-hide:all; font-size:1px; color:#ffffff; line-height:1px; max=
-height:0px; max-width:0px; opacity:0; overflow:hidden;">TH=C3=94NG B=C3=81=
O QUAN TR=E1=BB=8CNG: v/v Kh=C3=A1ch h=C3=A0ng c=E1=BA=A7n th=E1=BB=B1c hi=
=E1=BB=87n sinh tr=E1=BA=AFc h=E1=BB=8Dc</span>
<div class=3D"es-wrapper-color" lang=3D"und" style=3D"background-color:#F6F=
6F6"><!--[if gte mso 9]> <v:background xmlns:v=3D"urn:schemas-microsoft-com=
:vml" fill=3D"t"> <v:fill type=3D"tile" color=3D"#f6f6f6"></v:fill> </v:bac=
kground> <![endif]--><table class=3D"es-wrapper" width=3D"100%" cellspacing=
=3D"0" cellpadding=3D"0" role=3D"none" style=3D"mso-table-lspace:0pt;mso-ta=
ble-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin=
:0;width:100%;height:100%;background-repeat:repeat;background-position:cent=
er top;background-color:#F6F6F6"><tbody><tr style=3D"border-collapse:collap=
se"><td valign=3D"top" style=3D"padding:0;Margin:0"><table class=3D"es-cont=
ent" cellspacing=3D"0" cellpadding=3D"0" align=3D"center" role=3D"none" sty=
le=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;bo=
rder-spacing:0px;table-layout:fixed !important;width:100%"><tbody><tr style=
=3D"border-collapse:collapse"><td align=3D"center" bgcolor=3D"#ffffff" styl=
e=3D"padding:0;Margin:0;background-color:#ffffff"><table class=3D"es-conten=
t-body" cellspacing=3D"0" cellpadding=3D"0" bgcolor=3D"#ffffff" align=3D"ce=
nter" role=3D"none" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;bord=
er-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600p=
x"><tbody><tr style=3D"border-collapse:collapse"><td align=3D"left" bgcolor=
=3D"#F6F6F6" style=3D"padding:10px;Margin:0;background-color:#f6f6f6"><tabl=
e cellspacing=3D"0" cellpadding=3D"0" width=3D"100%" role=3D"none" style=3D=
"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-=
spacing:0px"><tbody><tr style=3D"border-collapse:collapse"><td valign=3D"to=
p" align=3D"center" style=3D"padding:0;Margin:0;width:580px"><table width=
=3D"100%" cellspacing=3D"0" cellpadding=3D"0" role=3D"presentation" style=
=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;bord=
er-spacing:0px"><tbody><tr style=3D"border-collapse:collapse"><td align=3D"=
center" style=3D"padding:0;Margin:0;font-size:0px"><img class=3D"adapt-img"=
 src=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dg=
d6j-2FSrkwssdeXdMntYfkRnTTmYtIMVzGNTKgGi8UXDagUeZd5S6YqckqWjm1Tw7jfk1cqfg2F=
qEaaaifjad2dhmOhzQrwkoRe304perj4FSk33toNFHEh8icGNAIq-2FX6GXB-2B230iEoKXrjLY=
9TuzXC3-2By0mWI1WIphZhdgipMC5jxYZzDeG840tNmeIfyKNbLfMYFFxPN-2Bsh7mLTP5JBvG5=
tfCFOig-3DYpCu_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2=
BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGes=
nHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo=
409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU=
4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tB=
NMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9Bd=
sMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBV=
otpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku=
4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2F=
K0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2=
FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3=
vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU=
34yugTysZP4Vxqh4K9MsDwe2D8GHnW0OZm48pm-2BCe5XlgVgpW7zdhT3lLLMuqmjDZ3Sf-2FsJ=
W0kj0QPBXwRqyk2nDudkpxXw1wk6y5aAFqxkrX-2Ba-2FHC8ZCse7tsfTzJ6exPl1EDRaX8eJXv=
a-2Bqzn260t7p7HsVDNUyOYtGQRWZzXhTbaVJzm-2FGkqp4SFwZmTVRIbqh9ogcIOf9-2BCua24=
RE9EuxbYbO8-2Btv8bZuXVO7GLZfumvLbJI469ozePhyKU1v alt=3D"" style=3D"display:=
block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bic=
ubic" width=3D"580"/></td> </tr></tbody></table></td></tr></tbody></table><=
/td></tr></tbody></table></td></tr></tbody></table> <table class=3D"es-cont=
ent" cellspacing=3D"0" cellpadding=3D"0" align=3D"center" role=3D"none" sty=
le=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;bo=
rder-spacing:0px;table-layout:fixed !important;width:100%"><tbody><tr style=
=3D"border-collapse:collapse"><td align=3D"center" bgcolor=3D"#ffffff" styl=
e=3D"padding:0;Margin:0;background-color:#ffffff"><table class=3D"es-conten=
t-body" cellspacing=3D"0" cellpadding=3D"0" bgcolor=3D"#ffffff" align=3D"ce=
nter" role=3D"none" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;bord=
er-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600p=
x"><tbody><tr style=3D"border-collapse:collapse"><td align=3D"left" bgcolor=
=3D"#F6F6F6" style=3D"padding:0;Margin:0;padding-left:20px;padding-right:20=
px;background-color:#f6f6f6"><table cellpadding=3D"0" cellspacing=3D"0" wid=
th=3D"100%" role=3D"none" style=3D"mso-table-lspace:0pt;mso-table-rspace:0p=
t;border-collapse:collapse;border-spacing:0px"><tbody><tr style=3D"border-c=
ollapse:collapse"><td align=3D"center" valign=3D"top" style=3D"padding:0;Ma=
rgin:0;width:560px"><table cellpadding=3D"0" cellspacing=3D"0" width=3D"100=
%" role=3D"presentation" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt=
;border-collapse:collapse;border-spacing:0px"><tbody><tr style=3D"border-co=
llapse:collapse"><td align=3D"left" class=3D"es-m-txt-l" bgcolor=3D"#F6F6F6=
" style=3D"padding:0;Margin:0;padding-left:20px;padding-right:20px"><p styl=
e=3D"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-l=
ine-height-rule:exactly;font-family:arial, 'helvetica neue', helvetica, san=
s-serif;line-height:24px;color:#001e98;font-size:16px"><strong>K=C3=ADnh g=
=E1=BB=ADi: Qu=C3=BD kh=C3=A1ch h=C3=A0ng=C2=A0</strong></p> <p style=3D"Ma=
rgin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-hei=
ght-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif=
;line-height:24px;color:#001e98;font-size:16px"><br/></p><p style=3D"Margin=
:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-=
rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;lin=
e-height:24px;color:#001e98;font-size:16px">Ng=C3=A2n h=C3=A0ng TMCP =C3=81=
 Ch=C3=A2u (ACB) th=C3=B4ng b=C3=A1o =C4=91=E1=BA=BFn Qu=C3=BD kh=C3=A1ch v=
=E1=BB=81 vi=E1=BB=87c Qu=C3=BD kh=C3=A1ch h=C3=A0ng ch=C6=B0a <strong>th=
=E1=BB=B1c hi=E1=BB=87n Sinh tr=E1=BA=AFc h=E1=BB=8Dc</strong>, =C4=91=E1=
=BB=83 kh=C3=B4ng b=E1=BB=8B gi=C3=A1n =C4=91o=E1=BA=A1n giao d=E1=BB=8Bch =
t=C3=A0i kho=E1=BA=A3n thanh to=C3=A1n, giao d=E1=BB=8Bch th=E1=BA=BB t=E1=
=BB=AB ng=C3=A0y 01.01.2025, Qu=C3=BD kh=C3=A1ch vui l=C3=B2ng th=E1=BB=B1c=
 hi=E1=BB=87n c=C3=A1c b=C6=B0=E1=BB=9Bc sau:</p></td></tr></tbody></table>=
</td></tr></tbody></table></td></tr> <tr style=3D"border-collapse:collapse"=
><td align=3D"left" bgcolor=3D"#F6F6F6" style=3D"padding:0;Margin:0;padding=
-left:20px;padding-right:20px;background-color:#f6f6f6"><table cellpadding=
=3D"0" cellspacing=3D"0" width=3D"100%" role=3D"none" style=3D"mso-table-ls=
pace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px">=
<tbody><tr style=3D"border-collapse:collapse"><td align=3D"center" valign=
=3D"top" style=3D"padding:0;Margin:0;width:560px"><table cellpadding=3D"0" =
cellspacing=3D"0" width=3D"100%" role=3D"presentation" style=3D"mso-table-l=
space:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"=
><tbody><tr style=3D"border-collapse:collapse"><td align=3D"center" style=
=3D"padding:0;Margin:0;font-size:0px"><img class=3D"adapt-img" src=3D"https=
://u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwssd=
eXdMntYfkRnTTmYtIMVzGNTKgGi8UXDagUeZd5S6YqckqWjm1Tw7jfk1cqfg2FqEaaaifjad2dh=
mOhzQrwkoRe304perj4FSk33toNFHEh8icGNAIq-2FX6GXB-2B230iEoKXrjLY9TuzXC3-2By0m=
WI1JsgyQ8HxLvo1Tg0-2BfGe3uJqsscfAwHw-2FI6SIYKSRGVXg239yHsWv-2Bdy7B513z58k-3=
Dqn9x_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxU=
l9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0M=
IDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2o=
O5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-=
2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2=
BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSej=
QCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX=
9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3Bhl=
JoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BL=
yLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Sci=
j2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypF=
j-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZ=
P4Vxqh4K9MsDwbnOJQGOzpUUUpw-2Fb22bOZdjZ9ZDSEDFc-2Be-2B-2FfRq6H8I3g6v4G-2FrI=
qx3bF4taoTJ4i90-2BZPhTVNon5PbXPxgeJmU86Q-2Fl7lzA-2Bk-2FhOflK6WDxaHpp9KVBmBS=
-2Fp7u1LbDKf-2FQa8np-2FW1NygsS9R19jsbfejyUpNVVwxb4R9A1TjdsymE91xZlGVlbEJHjv=
kpaqZJHe7f3BHlzF64G7cIKKy9y3EJMQpJ3VrsPQPVMWDTH alt=3D"" style=3D"display:b=
lock;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicu=
bic" width=3D"560"/></td> </tr><tr style=3D"border-collapse:collapse"><td a=
lign=3D"left" class=3D"es-m-txt-l" bgcolor=3D"#F6F6F6" style=3D"padding:0;M=
argin:0;padding-left:20px;padding-right:20px"><p style=3D"Margin:0;-webkit-=
text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactl=
y;font-family:arial, 'helvetica neue', helvetica, sans-serif;line-height:24=
px;color:#293689;font-size:16px">Vui l=C3=B2ng b=E1=BB=8F qua th=C3=B4ng b=
=C3=A1o n=C3=A0y n=E1=BA=BFu Qu=C3=BD kh=C3=A1ch =C4=91=C3=A3 th=E1=BB=B1c =
hi=E1=BB=87n Sinh tr=E1=BA=AFc h=E1=BB=8Dc<br/></p><p style=3D"Margin:0;-we=
bkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:e=
xactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;line-heig=
ht:24px;color:#293689;font-size:16px"><br/>Tr=C3=A2n tr=E1=BB=8Dng,=C2=A0 =
=C2=A0 =C2=A0</p></td></tr> <tr style=3D"border-collapse:collapse"><td alig=
n=3D"center" style=3D"padding:0;Margin:0;padding-bottom:10px;font-size:0px"=
><a target=3D"_blank" href=3D"https://u45836307.ct.sendgrid.net/ls/click?up=
n=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwo07iou63cwsWyQfBw3dWt0H9oR1nNj6NwMBk-2F5-2B=
Plo1VeSljlQZqv0QN6DAQEc99IU71nMX9-2BjK-2F5s5ZB8yLMQoV3TkApYAQJe6c1DiEPA0rqR=
lQ6JxtHlwTZxMcUvRtT-2FONN3UX4ywam2eBnLc7pPeY-2BcXi2hlEru90W1zLChVqxW4fgPaHY=
vl1zhxJtgJQIDVdncfu-2FRgav3R-2F629YPvdks2KIjde1ILNFqMWAoUaujSFrtdxZyVF6bgyS=
TRryrhCeaBrEnRk5CEv1mrA9wNGB8-2BdLfRsqxRZXHt9i7K01Aojudeu0QbJc5oeyuQCqfqMq9=
6RXy13aBzbzujimZ89uMDTM46uQPEPovya97kzYQuOzKk0ivuqAMBzesamWY59recaXC-2FjzlR=
ZSh5Jq8rYBjamsYpXu2lP9zGU4DF12hHH_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2Bj=
IARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqq=
fECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdE=
hoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem=
0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflR=
urLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklf=
oQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7=
JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18Bbcpk=
F0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl=
-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf=
9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vE=
rf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqW=
qwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwd9HJ0J97ZilCGEhwdH5i9co41SzEkdpyTU=
hp-2BcLEcMwMh77K-2BLoG4qQA61IeUYeXisnZR5ogkufQ61Cs2R7PlehEn3gGER-2FXXKmzCzb=
kW2Ft-2B9eod-2BAT-2F2lUXIj-2BThwrzKsV-2FZvD-2BQM8Qnm0X47FU23jNOOSAavXHv8Hbd=
dgPARpwMleyjD0e3E8tSGVyWzbvSC3IXqH429URmNlYsCwpIrJHfS1uIGJ3TyZ7eCfFVL style=
=3D"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height=
-rule:exactly;text-decoration:underline;color:#333333;font-size:14px" class=
=3D"ins-vib-link"><img class=3D"adapt-img" src=3D"https://u45836307.ct.send=
grid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkRnTTmYtIMVz=
GNTKgGi8UXDagUeZd5S6YqckqWjm1Tw7jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoRe304perj4F=
Sk33toNFHEh8icGNAIq-2FX6GXB-2B230iEoKXrjLY9TuzXC3-2By0mWI21bHW0BER7SV4Qfb-2=
B675HZiHSdHyc7W5HgaXVChP78og-3D-3DguGI_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhne=
R-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqO=
eMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhA=
AkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62=
ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO=
0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIo=
FUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40=
ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18=
BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26=
XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQR=
YlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGY=
O59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljz=
o6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwZpanVqFZMO8PpzzQfA-2FSlsYUdCK=
x1mSuOldTLiQB48ET8s0PYSksOeT7WAUtWa0wAakeUbVtpQzzJTp7C2W9J4p14Qm9WBPozK9BQy=
ybMq8v86-2BHyZpykGN-2BnxuBM5J-2BTgLUNAMaYgrlXYnRCtxS-2F7gPRpPeHnIYtIzeqUgWQ=
rTDRaDhANH-2B2WCkqdTWwUeE92oNO0aQFWk6Nie-2B3oYydJqWHS7kx7R-2BRZL68RGPgQD al=
t=3D"" style=3D"display:block;border:0;outline:none;text-decoration:none;-m=
s-interpolation-mode:bicubic" width=3D"560"/></a></td></tr></tbody></table>=
</td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></tab=
le> <table cellpadding=3D"0" cellspacing=3D"0" class=3D"es-footer" align=3D=
"center" role=3D"none" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;b=
order-collapse:collapse;border-spacing:0px;table-layout:fixed !important;wi=
dth:100%;background-color:transparent;background-repeat:repeat;background-p=
osition:center top"><tbody><tr style=3D"border-collapse:collapse"><td align=
=3D"center" bgcolor=3D"#ffffff" style=3D"padding:0;Margin:0;background-colo=
r:#ffffff"><table class=3D"es-footer-body" style=3D"mso-table-lspace:0pt;ms=
o-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-c=
olor:#002395;width:600px" cellspacing=3D"0" cellpadding=3D"0" align=3D"cent=
er" bgcolor=3D"#002395" role=3D"none"><tbody><tr style=3D"border-collapse:c=
ollapse"><td align=3D"left" style=3D"padding:0;Margin:0"><table cellspacing=
=3D"0" cellpadding=3D"0" width=3D"100%" role=3D"none" style=3D"mso-table-ls=
pace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px">=
<tbody><tr style=3D"border-collapse:collapse"><td valign=3D"top" align=3D"c=
enter" style=3D"padding:0;Margin:0;width:600px"><table width=3D"100%" cells=
pacing=3D"0" cellpadding=3D"0" role=3D"presentation" style=3D"mso-table-lsp=
ace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px"><=
tbody><tr style=3D"border-collapse:collapse"><td align=3D"center" style=3D"=
padding:0;Margin:0;font-size:0px"><img src=3D"https://u45836307.ct.sendgrid=
.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkRnTTmYtIMVzGNTK=
gGi8UXDagUeZd5S6YqckqWjm1Tw7jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoRe304perj4FSk33=
toNFHEh8icGNAIq-2FX6GXB-2B230iEoKXrjLY9TuzXC3-2By0mWI060THYF3NtpSkzhU-2BxDK=
lfvdDytewlX1uvA7Pq7xorWw-3D-3DHGIi_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2B=
jIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEq=
qfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKd=
EhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJe=
m0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kfl=
RurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUkl=
foQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX=
7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18Bbcp=
kF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNht=
l-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEz=
f9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59v=
Erf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zq=
WqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwYUEpVZ9KP8I5uPzDXleOioPYcs-2B4Hxd=
Y9lo0r4iw95mTr0k4eO8LKygMD4rYTCiAe7cbT57vtBslHxyKBO2kpVDOF-2BcwSDJDsmrmIqWB=
pXvv0-2BaXTG-2FmGLlGeVIAC298EwAbo-2FidBvfk7eknSgX0Vv6XxbMxwKRGcLUVvXunwmc-2=
FmgnlSMY21aPZfhtUaJNz7IffU4pb879IcWGUMqBApGDrTvhg-2F783f2tyXewUin8 alt=3D""=
 style=3D"display:block;border:0;outline:none;text-decoration:none;-ms-inte=
rpolation-mode:bicubic" class=3D"adapt-img" width=3D"600"/></td> </tr><tr s=
tyle=3D"border-collapse:collapse"><td align=3D"center" style=3D"padding:0;M=
argin:0;font-size:0px;background-color:#002395" bgcolor=3D"#002395"><table =
cellpadding=3D"0" cellspacing=3D"0" class=3D"es-table-not-adapt es-social" =
role=3D"presentation" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;bo=
rder-collapse:collapse;border-spacing:0px"><tbody><tr style=3D"border-colla=
pse:collapse"><td align=3D"center" valign=3D"top" style=3D"padding:0;Margin=
:0;padding-right:15px"><a target=3D"_blank" href=3D"https://u45836307.ct.se=
ndgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwm4s6OMGFY4w1y34rLJ5LC=
3nnGidLTeDKF7niTnowhspuAY7V-2Fwzh6wGYRmryimMXXAYtVr-2FnKoNcpOKtyiXSJiTihPf5=
mDWrFySvsCMCb-2BGBCaWSBlPuwicih3RrFWWvgR4cU0uv97THKav-2BGVpNF-2FycFXg5Kxl9h=
9HL3VACCVbtrVFZZPoBYicD2YM2HUni1GQbYG1VJMdu4WdZldQG2kBrUfDOxOxwya9-2FgVC9VP=
8dSwflgIwE24t7r4FKdynF7fdoDpQNM-2F3DANpe7WAc5Xvs7daYo1hTB4FzSLyatOu13oW_XA-=
2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2=
F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbK=
zHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1g=
JQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kk=
RTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h=
5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyc=
kPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbv=
tlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-=
2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WR=
WRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwb=
b-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5=
TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9=
MsDwQIG0nywPqxOtXZ3OwkIOBqSwDf-2FH-2F2-2BwV3xicqS11du7L1gdOR9OMh5PZONgzdAMB=
xQVgh7E8k7CfIhfC6kuFHqTiAxoozzWthBq-2B9xkTx7QXVYmGOMvD-2FZaBgC8c8zI2uqzw7iU=
i-2Fmj-2FEvR9b3euBmRksmcDj3lN7O90k7ry7-2FqEoYZSRezJQqze915auYgW6a1rRE7BxpyY=
UupPe9T6j8KPra7j3NT6PWr5LD9-2F2W style=3D"-webkit-text-size-adjust:none;-ms=
-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:underli=
ne;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img title=3D"Faceb=
ook" src=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQW=
I1Dgd6j-2FSrkwsRx-2FGtSmTFY5YMQavEoIBnoaZ4Jry-2BvNlmfQvdIVpzXsKTHig9zpW-2FG=
4xIM9wTDO8tOrza9fauQ22XnSfyOxXg-3D_4Lr_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhne=
R-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqO=
eMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhA=
AkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62=
ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO=
0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIo=
FUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40=
ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18=
BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26=
XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQR=
YlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGY=
O59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljz=
o6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwf-2FsjNZV6VthtXc-2Fg27BPruaCo=
URKLJbU0MZSvkY1iIw-2BXX9Ki9OVAXlBpCWgOyeYwVRDb4fXZLyMR89RiR3-2Ba0bFghSBpMrM=
WDh4C1bhHqSZnwTNIMzJZoOSpTQm-2FuQaQzbwUoXxiz-2FIunD8C84MP-2BSyW7OAcCIVfJP4v=
bpYds9-2B7A-2BAObBK2UH1UBkRKOPlWMebj81461ZJyGQIIfPJJTAI1kRChlGDVY301sl7lN6 =
alt=3D"Facebook" width=3D"32" width=3D"32" style=3D"display:block;border:0;=
outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"/></a></td=
> <td align=3D"center" valign=3D"top" style=3D"padding:0;Margin:0;padding-r=
ight:15px"><a target=3D"_blank" href=3D"https://u45836307.ct.sendgrid.net/l=
s/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwrs17boCYLVoZcoIP38kDFjOkDV9wAj-2B=
U4aX33iOziU5iAtqBonFb2UJl8f0vOLXHVQgrn-2BNxOoRz4wY2Aan1nrYpqV-2FM16tvL0D31T=
or6IkqCh-2Fk9bDE3d-2FuPdaPZzIr-2F0IgfbzjyzQTWXNPOebolCV5HglfgigEjL0WhQYAhL6=
dVYO3oPnbWmLoVq1KL5PvQUG7yRcfOIBRpAVjbEgZn1NXAzIApTUL2hwnNqiw-2FX-2FbdOHSJu=
sQYG2PMUNPnRkoyhxZmNAmFmkj1eyJc9PAG8R2chj858hduQxY8RF6NA7yQ1kg-2FWT98GLYEtI=
JVY65A-3D-3Dk-tB_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B=
-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozG=
esnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8Czvng=
Go409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nY=
pU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0=
tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9=
BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLM=
BVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmY=
ku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-=
2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L=
-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwg=
L3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdU=
VU34yugTysZP4Vxqh4K9MsDwcAygjYWAv5JmbZBzszjPkWMuwqnGwsqn1miXDBDsLvIkiVJ4lv3=
lwY2k-2BOVaPQFBNMOuXYpmt6EnwzI4WIzywe4EecE0FXQCPAq6f8jGguVd4MDC6Fch4HkPNUGQ=
xK-2BHdE-2BakOdQisv2ehiSUI9FZPBPXdJTPVnkvcM4uNUcr1oL5cE2re0P1aXvtuKRjt9jFzl=
C2-2F8VLOwvxfMhnNUXRo2WPwYxO8G6EEuAwXTZ4N6 style=3D"-webkit-text-size-adjus=
t:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decorati=
on:underline;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img titl=
e=3D"Tiktok" src=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du001.Q=
YAJQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkRnTTmYtIMVzGNTKgGi8UXDagUeZd5S6YqckqWjm1T=
w7jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoRe304perj4FSk33toNFHEh8icGNAIq-2FX6GXB-2B=
230iASMmmubk8C-2BM4eURiVWrbMXa2RHHihoxN1TZCMYe-2F253mTHafLX-2B3o6zawVZXTP-2=
F-2Bho2RQmRC5kvHv94MbipHg-3DvgUW_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjI=
ARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqf=
ECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEh=
oDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0=
M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRu=
rLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfo=
QfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7J=
SPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF=
0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-=
2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9=
taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vEr=
f6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWq=
wRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwUmAQl33YpMOszlFjoVpHt6HVxqiS4eLbPQj=
YV095ilRrXAxw6zBx9iU4mCp1TkE4HXKCyCDElQc06qlFSVnnvULyKMIoM-2BddmQd8p2dUEWBl=
Z2tLjRdqCiqJxXMD7m5JEYCTD6z-2FhYr8SSYeo6iV7ft-2BQAeAJjQCjZsgClcFwoug5wIVK0v=
vcFpPjmQJeCYQXM8hIB4jb17TOoo9nrblECVSkbsDE-2F5Av6eUMTF0kAm alt=3D"Tiktok" w=
idth=3D"32" width=3D"32" style=3D"display:block;border:0;outline:none;text-=
decoration:none;-ms-interpolation-mode:bicubic"/></a></td> <td align=3D"cen=
ter" valign=3D"top" style=3D"padding:0;Margin:0;padding-right:15px"><a targ=
et=3D"_blank" href=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du001=
.QYAJQ2tQWI1Dgd6j-2FSrkwpLRSnVe8SVWaECdG4Y1iu7xlxZPGooUqXHNDBNdowF13-2FAFVb=
-2FH-2BLDYDihF2JbUW2uiDWRM4uFNmbunZIXy5eWMrris5Wgz1WSF12Qeb37YwCiP8JcHDKv8p=
uswyD7Cgc53F-2FECc62WfuXEYWYvQX6HW-2BUapLLXYemuSISMrhfBKTUUZIpLtXitj0UNXHE0=
Poi6S8hZuYiSmta4hMNQwTZi0isCbonrHf-2BhImP8idoxa8JlLGPGUKdiJCOUJUOK-2B89VOtG=
dJTfqg2M8DZts9dZMqOQZ6tYyDyb5iIftzCvILX27_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDh=
hneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0=
tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJ=
LhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKL=
n62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuis=
ziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxt=
wIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQ=
b40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9=
n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rl=
q26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FI=
LQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5h=
gGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUD=
ljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwZHFBMSWnkIEF8hs4KNEMF40pdi=
Ai-2FNPpcXOEW3SDOfkiCk90NJWDEZKtjwmUcQKt75LeT7kjxA7K78XtEQmzG00Ibm80NPGHGb5=
NU7Ff3OYI3rVLM5kXxyoNVq0HLwNmfIm-2BtpBiP8vxu8Ovl-2BgpMp3mWfUrT051O1ubURDMPr=
JDbfV8Vsl-2F0t42NkW9G3xz-2BNMhRpcMNRlHuuTZxn-2Fd01LBXZs-2FcCd4f7Ju3C-2FfVMK=
 style=3D"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-=
height-rule:exactly;text-decoration:underline;color:#FFFFFF;font-size:14px"=
 class=3D"ins-vib-link"><img title=3D"Zalo" src=3D"https://u45836307.ct.sen=
dgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkRnTTmYtIMV=
zGNTKgGi8UXDagUeZd5S6YqckqWjm1Tw7jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoRe304perj4=
FSk33toNFHEh8icGNAIq-2FX6GXB-2B230iASMmmubk8C-2BM4eURiVWrbMXa2RHHihoxN1TZCM=
Ye-2F25o6vhblvuc14YY2lHFeKgHw-3D-3DRDGS_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhn=
eR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tq=
OeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLh=
AAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn6=
2ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuiszi=
O0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwI=
oFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb4=
0ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n1=
8BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq2=
6XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQ=
RYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgG=
YO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDlj=
zo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwez-2F8xdNKgdkjBRkD7gySJ6Z0vK=
B6t3UHCH0m38DVdK3dX-2FzDsd-2BWmTtshN9PXK-2FTlu7BbGNT-2BCjZP4u2M1DKd6AqajX57=
QwxPAo45ev8BrWvJCytLMfDmj-2FfHkeKSlehI1-2BgHiav4IN3Qh-2B0zLGlUkr5LspFCpEHS8=
3fdLayXgprWhABJ7L0eqlYcpw-2BxG9QqP6ZkE2LTRidbsG1RZmQFV7cxWMxCVotARoHvMZf4rw=
 alt=3D"Zalo" width=3D"33" width=3D"32" style=3D"display:block;border:0;out=
line:none;text-decoration:none;-ms-interpolation-mode:bicubic"/></a></td> <=
td align=3D"center" valign=3D"top" style=3D"padding:0;Margin:0;padding-righ=
t:15px"><a target=3D"_blank" href=3D"https://u45836307.ct.sendgrid.net/ls/c=
lick?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwuNi-2F2tr8kE3phSP6yKXt4e1VMvG7Mn4dwh=
Z24rpqWpll6XJU3VDNqDwx8jFhiry83p-2Fwf5bnuzlPKwpCL-2FTFjfa3Gck4Tg-2B-2BG-2FU=
CXVmnfJURPRseE6oUGq4aYWSPAUOfSX2QVNx6sPE5eWCk63fUw-2BbaT92LS3cg1Ocr-2BdUUhD=
9e5YjKCtBK-2BKIH-2BYtTpx9Od-2FPfigHdBhorypuQXkZ28vgw3UAgJ1B0GnJlYxJmHkdlUzX=
Dbtfm1jLjO2bs-2BbkJZe9u6i-2B7XjCTAciyjyXV-2Bry1ZmZM5isXmjSJVCKeJR7TnTjqSiUD=
6WBI-2BCg5c9Rkxijk-2BRBIdIBx8Zi02S3zFU-3DYS72_XA-2BSAJ5yQ16bYvknef-2FUg5JWh=
PMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw=
-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15=
TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAn=
hXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewa=
JuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf=
3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYx=
bYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCui=
ycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO=
77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP=
-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACL=
nP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANi=
foUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwfryFkBrxJ3U-2BwQzxfCjx=
4FDVOKzWfT9k1UfRWhq-2B376e2F2jwFwz-2FCoRx-2Frrs5g07-2BjjIp7cxhjTMqrUoC71ZVa=
SssciomLsu9Y1GtzG9a9A3bUv7xCWCkNuwnQJ8bsfL6WY6N-2FeeSyOKOlVkvJtNQnwdnWtw2vO=
PfRoOVla5wnbVyIgYUPp6-2BfI1ltBQ9kayVeCcAbFWpAuJD13hQlIgJdUtylg8ZdE-2BD-2BJr=
CNXNfZ style=3D"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso=
-line-height-rule:exactly;text-decoration:underline;color:#FFFFFF;font-size=
:14px" class=3D"ins-vib-link"><img title=3D"YouTube" src=3D"https://u458363=
07.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkR=
nTTmYtIMVzGNTKgGi8UXDagUeZd5S6YqckqWjm1Tw7jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoR=
e304perj4FSk33toNFHEh8icGNAIq-2FX6GXB-2B230iASMmmubk8C-2BM4eURiVWrbMXa2RHHi=
hoxN1TZCMYe-2F25YpJ-2BiXuYb2RK4o28uU0-2FXw-3D-3DlmMV_XA-2BSAJ5yQ16bYvknef-2=
FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN3=
67wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI=
5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0b=
VdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uq=
dbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDb=
KkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vk=
ivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2Fi=
baqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh=
5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ec=
xHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9=
Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcI=
Jho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwcR-2FVoN0VhGPx9=
KBzdoRp-2BpF5BkHUcDBGFEU4f-2BdYeLDsW5dhhUAwngoeB8O4P5H3MPODuD1UnlODKcNjuuOB=
qBXSYMVSGXQ4evyEMOwxZ0lCt-2B7IluwIdQ6PILu-2FDk8dwgQkc-2BSmnCoyuMOIQvDTMzcX8=
GzWuQabviSuGPjKN2YVVf-2FSs8-2BPB2-2FD1RHCipJO-2Bs7nay6nL1xQjxwrMtslrAJq1Klf=
Cu78l3zQRc5AiKh alt=3D"Yt" width=3D"32" width=3D"32" style=3D"display:block=
;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"=
/></a></td> <td align=3D"center" valign=3D"top" style=3D"padding:0;Margin:0=
"><a target=3D"_blank" href=3D"https://u45836307.ct.sendgrid.net/ls/click?u=
pn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwmEFlESLMKGTSbQ8evuUpay-2FTzxU9cb0Pp2DbmMwJ=
svt3m2qn3SXTqaA9oxlU8Ii08LtP7nNMeB-2BNHhXPWTkAC1EmaIxahgypizEX7yaC83yfP9ImN=
QImYf1kCdrOQ0b-2BcI-2B2CzV-2FOrF3L1vd5106GihcUVb5gWYE9Tx-2BQlxMXJqk-2BkZN2-=
2BewWxfOgJ6tgUZa7FZVEaDyieOCF9N5HMp1VVYslie4omJD68WBOMaxV3zjsxOvFIwNGO6Y89E=
WVdOpU1RxtM4zcooVNuahwlQ5T26M9tRUyDp743gZyaIUNG2NqQuJnmS41-2FVwlqc3NuflA-3D=
-3Dx7Tl_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvS=
xUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u=
0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s=
2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnT=
q-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK=
-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOS=
ejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFV=
zX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3B=
hlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2=
BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1S=
cij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAy=
pFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTy=
sZP4Vxqh4K9MsDwezigRhMiGWua8abzEuxDGdAOoW549Wb4AUjc6TKlbTx2EuP-2FLFcMN6ly6G=
2L3Yd1XU0C0b0GcoW1C6iSWUp6tQvRiBWanO-2FhrAP3cB4XfHYHAMxqmoJF5TIdIDFOyYaRfCF=
0chb3NWlKrXTeY5eUhHbuFFkvzNzrvW8TXdjg7vlFHZEJK-2FUn2Tv4-2B-2Fozgu5HaA7FAV4W=
3CPcPZB-2FqtAThtBO4Rgf0J6YwBIj4ZCNNE9 style=3D"-webkit-text-size-adjust:non=
e;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:un=
derline;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img title=3D"=
Instagram" src=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYA=
JQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkRnTTmYtIMVzGNTKgGi8UXDagUeZd5S6YqckqWjm1Tw7=
jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoRe304perj4FSk33toNFHEh8icGNAIq-2FX6GXB-2B23=
0iASMmmubk8C-2BM4eURiVWrbMXa2RHHihoxN1TZCMYe-2F25dYpILZPk0GxSAYcxPoqboQ-3D-=
3Dfsvt_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSx=
Ul9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0=
MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2=
oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq=
-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-=
2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSe=
jQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVz=
X9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3Bh=
lJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2B=
LyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Sc=
ij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAyp=
Fj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTys=
ZP4Vxqh4K9MsDwb-2BmAY9us1J6FmQLQyNZeoMat6U8UiT-2Bx-2F3VHGOwl6kg3cz9PPMr-2B9=
j0z5Kcn0BVi9s5AXmmSL3jB-2F8A-2BU8vTKCJZW-2B28fb4VGdErNFlKA-2BNbPu-2B-2FexT6=
XmwjcIivV4pwbq0-2FHfs5qgr1pycyT8pK-2FebSFyE-2FRKxf1I8muBs8Me6AXm6KdvHFkL7AX=
ydTZKgfrHApd3Lwczz99CQm-2BSQbZfF78KQGwpJ6EndS5gkIA9p alt=3D"Ig" width=3D"32=
" width=3D"32" style=3D"display:block;border:0;outline:none;text-decoration=
:none;-ms-interpolation-mode:bicubic"/></a></td></tr></tbody></table></td><=
/tr> <tr style=3D"border-collapse:collapse"><td align=3D"center" class=3D"e=
s-m-p10t es-m-p10r es-m-p10l" bgcolor=3D"#002395" style=3D"padding:0;Margin=
:0;padding-top:20px;padding-left:20px;padding-right:20px"><p style=3D"Margi=
n:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height=
-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;li=
ne-height:15px;color:#f1f1f1;font-size:10px">=C4=90=C3=A2y l=C3=A0 h=E1=BB=
=87 th=E1=BB=91ng email t=E1=BB=B1 =C4=91=E1=BB=99ng c=E1=BB=A7a Ng=C3=A2n =
h=C3=A0ng TMCP =C3=81 Ch=C3=A2u. Qu=C3=BD kh=C3=A1ch nh=E1=BA=ADn =C4=91=C6=
=B0=E1=BB=A3c email n=C3=A0y v=C3=AC Qu=C3=BD kh=C3=A1ch</p><p style=3D"Mar=
gin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-heig=
ht-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;=
line-height:15px;color:#f1f1f1;font-size:10px">ch=E1=BA=A5p thu=E1=BA=ADn =
=C4=91=E1=BB=83 Ng=C3=A2n h=C3=A0ng =C3=81 Ch=C3=A2u ACB g=E1=BB=ADi =C4=91=
=E1=BA=BFn cho Qu=C3=BD kh=C3=A1ch c=C3=A1c th=C3=B4ng tin v=C3=A0 giao d=
=E1=BB=8Bch li=C3=AAn quan =C4=91=E1=BA=BFn s=E1=BA=A3n ph=E1=BA=A9m</p> <p=
 style=3D"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;=
mso-line-height-rule:exactly;font-family:arial, 'helvetica neue', helvetica=
, sans-serif;line-height:15px;color:#f1f1f1;font-size:10px">v=C3=A0 d=E1=BB=
=8Bch v=E1=BB=A5 c=E1=BB=A7a ACB.</p></td></tr><tr style=3D"border-collapse=
:collapse"><td align=3D"center" class=3D"unsubscribe-block" bgcolor=3D"#002=
395" style=3D"padding:0;Margin:0"><p style=3D"Margin:0;-webkit-text-size-ad=
just:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-famil=
y:arial, 'helvetica neue', helvetica, sans-serif;line-height:15px;color:#f1=
f1f1;font-size:10px"><a href=3D"https://u45836307.ct.sendgrid.net/ls/click?=
upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwt5HYe09AeukTXKjMWRfoX8DlAXWDK0hUqgdVYBaZG=
mQwTyCqJCTRrm9cH7hqP896O9iEj6Y-2B-2Bq9NVNmKkTTBsadYsvK8u-2Fko-2FfoeK8ab43n1=
hK5G09x5EzILWWzPbPidbrKihqLGTD-2BiQp7LZGxgAc-3Du_6T_XA-2BSAJ5yQ16bYvknef-2F=
Ug5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN36=
7wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5=
m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bV=
dZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqd=
bNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbK=
kAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vki=
vO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2Fib=
aqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5=
BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecx=
HdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Z=
xe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJ=
ho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwbrqPqbL4dPUICW7k=
7-2BWrjvuVl0Eosvb77kOy31gvyrt3EadQn-2FwkIAyKyZwVyea1duNs-2BUlTkShdKosJp7NQH=
Ku7RNuIeEi-2B0-2Bfbuheabq2tBHEXdZX6OMfbX8T2N-2BdYMdLxhPN6cg9rNfG-2Fe4neZizd=
BklohIdHvIil6vnFvsNmKfkt2rjO1zmFSUk8Nri7XW5G-2BzaxwlUyu1eWF45PKFTfrZrITvrGx=
GRal7b-2FRS0 class=3D"unsubscribe-link" target=3D"_blank" style=3D"-webkit-=
text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactl=
y;text-decoration:underline;color:#ffffff;font-size:10px">Qu=C3=BD kh=C3=A1=
ch c=C3=B3 th=E1=BB=83 ng=E1=BB=ABng nh=E1=BA=ADn c=C3=A1c th=C3=B4ng b=C3=
=A1o khuy=E1=BA=BFn m=C3=A3i t=E1=BB=AB ACB b=E1=BA=B1ng c=C3=A1ch nh=E1=BA=
=A5n<strong> v=C3=A0o =C4=91=C3=A2y</strong></a> *</p> <p style=3D"Margin:0=
;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-ru=
le:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;line-=
height:15px;color:#f1f1f1;font-size:10px">Vui l=C3=B2ng kh=C3=B4ng tr=E1=BA=
=A3 l=E1=BB=9Di th=C6=B0 =C4=91i=E1=BB=87n t=E1=BB=AD n=C3=A0y</p></td></tr=
><tr style=3D"border-collapse:collapse"><td align=3D"center" class=3D"es-m-=
p10" bgcolor=3D"#002395" style=3D"padding:5px;Margin:0"><p style=3D"Margin:=
0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-r=
ule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;line=
-height:15px;color:#f1f1f1;font-size:10px"><br/></p> <p style=3D"Margin:0;-=
webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule=
:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;line-he=
ight:15px;color:#f1f1f1;font-size:10px"><strong>M=E1=BB=8Di th=C3=B4ng tin =
c=E1=BA=A7n h=E1=BB=97 tr=E1=BB=A3, Qu=C3=BD kh=C3=A1ch vui l=C3=B2ng li=C3=
=AAn h=E1=BB=87 t=E1=BA=A1i:<br/>Ph=C3=B2ng ch=C4=83m s=C3=B3c v=C3=A0 d=E1=
=BB=8Bch v=E1=BB=A5 kh=C3=A1ch h=C3=A0ng - Contact Center: 1900 54 54 86 - =
(028) 38 247 247 </strong></p><p style=3D"Margin:0;-webkit-text-size-adjust=
:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:ar=
ial, 'helvetica neue', helvetica, sans-serif;line-height:15px;color:#f1f1f1=
;font-size:10px"><strong>ho=E1=BA=B7c 1800 577 775 (Mi=E1=BB=85n ph=C3=AD -=
 d=C3=A0nh cho kh=C3=A1ch h=C3=A0ng =C6=AFu ti=C3=AAn)</strong></p><p style=
=3D"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-li=
ne-height-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans=
-serif;line-height:15px;color:#f1f1f1;font-size:10px"><br/></p> <p style=3D=
"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-=
height-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-se=
rif;line-height:18px;color:#f1f1f1;font-size:12px"><strong>Qu=C3=A9t m=C3=
=A3 QR ho=E1=BA=B7c t=E1=BA=A3i =E1=BB=A9ng d=E1=BB=A5ng t=E1=BA=A1i</stron=
g></p></td></tr><tr style=3D"border-collapse:collapse"><td align=3D"center"=
 style=3D"padding:0;Margin:0;font-size:0px"><a target=3D"_blank" href=3D"ht=
tps://u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkw=
kozUADpM9Nbhn-2BW7gwOaZDsBQqSXJKBaH1c3ZK0Ar-2FMlWFM9YshcmMEBQx9AKcQKf-2FxFk=
V73uXOBL9byZ-2FQhPX7xzhN7o-2Bb1g-2F0ZmMJ6U-2FYQpxAHmGbX0srY-2B6IEWmC1pbNo6B=
2kngAEPpVvAnc72IR-2FaY8f99uYXMwz2rbwWY6ksay0nvqcycaoTIwapgMVqhmscrfzc2zM5iK=
W-2FckKq-2ByHt2oEXaQ-2Bs8Bt-2Fozdqa35w1UEGJvC8rlLdM8RCwYTYZpHhfAtO44sxj6Kx0=
iOjHk28jHYAxUBGxApALUXDzyfO-2FsbtiLSn-2F4NOKD9lVvEA-3D-3D_5M0_XA-2BSAJ5yQ16=
bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe=
-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w=
-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8=
NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc=
8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3C=
OVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQS=
d-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNH=
d034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5=
554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609=
pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwH=
o7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCi=
pfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwQUI89w=
l5R9kKdrj0OK6IAsKdMgWTI-2FOMEbtHqrCcXtlQQufITVDQKk0fqTktga0N8F9bf85U7jtof77=
AaWZ2ISOj9rxhFezsg7nI6MgD-2Fw3-2FIynr9cCi03T0TPpksB9O79TsSk1mj24vci3WrlSsyG=
5bJLICp0of7zW9hBqU396SwTFsA7jweiIV6Vw92-2BYcw-2B2ia1EkrC08a-2FQs2w5nzHXK-2F=
8m-2Fzrty9ZW3Kke-2B9Ci style=3D"-webkit-text-size-adjust:none;-ms-text-size=
-adjust:none;mso-line-height-rule:exactly;text-decoration:underline;color:#=
FFFFFF;font-size:14px" class=3D"ins-vib-link"><img src=3D"https://u45836307=
.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkRnT=
TmYtIMVzGNTKgGi8UXDagUeZd5S6YqckqWjm1Tw7jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoRe3=
04perj4FSk33toNFHEh8icGNAIq-2FX6GXB-2B230iEoKXrjLY9TuzXC3-2By0mWI1CNpmkvCBA=
ZFcQHov1Fsx1xTmh6Orr8d3m1CFIhH9CEA-3D-3Dhd5m_XA-2BSAJ5yQ16bYvknef-2FUg5JWhP=
MDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-=
2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15T=
zXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnh=
XKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJ=
uisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3=
qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxb=
YBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiy=
cF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO7=
7rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-=
2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLn=
P5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANif=
oUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwRrtQBrWwT4UL6D2ro7uNuQ8=
wRZPWzdYrw1oRc0uE4XJOosxY-2Bl3sPcFn9p895tsWGSviUpVNbFf4Sse-2B6po1X2bEtNaLbs=
orQeJ7vLuJSlLgEQGllu6SWPUaUxCcgHcMVFv7VUBHbqin-2BhzFYJRPOgRNREVrJHnGmzz-2B3=
sbapHjz69W-2BwbQclpwCrU4Xn5r-2B9dbTKI5wIKfZX24EUM-2FWi7FDnG5-2FHVceDfxcRFyM=
9mP alt=3D"" style=3D"display:block;border:0;outline:none;text-decoration:n=
one;-ms-interpolation-mode:bicubic" class=3D"adapt-img" width=3D"600"/></a>=
</td></tr> <tr style=3D"border-collapse:collapse"><td align=3D"center" styl=
e=3D"padding:0;Margin:0;font-size:0px"><a target=3D"_blank" href=3D"https:/=
/u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwqKLgt=
DRaI699Wj9rZVVmBqAz3lQasPNMD8Nixu3hFkZyHHDdYV9oMlxYN5QWwz288o4Oc2I1M9arUalV=
ZxXXO-2FbbPUf7RhBr3j9vcIfN9pVk2eVDwIM1gP32fW5MkyenrTWJJJb7lKBWg-2F5Ig-2BVkk=
-2Bv-2BOBc20tVPRNR32endoM92KRxkYjY4oJ5Zskd8Ainy4uO8FOKXTT-2FBfEEThCoO3A3fr8=
PvLW-2BE-2BD2RGUSpCDbdy2jYZlBCuSanhVRq-2FnO2KYxR0I4V0XRiJq1foq9-2BDvA3agh-2=
FHuAX4OOPvFZuC5Dvj985kRTPmfVj7rIMlYd7jxaG7XnFqv81nnmUSVy4OStSDR90GN4Vp8Nc0r=
EQvF0nPqq_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjb=
vSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN=
5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc=
1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocN=
nTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViX=
tK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4l=
OSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWM=
FVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI=
3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w=
-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo=
1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIV=
AypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yug=
TysZP4Vxqh4K9MsDwRfX198hO1oTSBfYIbZMj-2FFDGT41fwmhuyAI5GA4plyIjK-2FFp1vDHw-=
2FtFNsnP0GQ3PXVdeOLZNP2W1VWNBQrOKQJ6Oe0XvUHtUEmUfCMDEdDXPFgrdrUHCELLHGVdNRQ=
Su5n-2BKkVOg-2BlHZYx84L0nFfZAHaX6g4C9DRTpXJYQzF5r3U9NNRT5-2BOolRtT-2BO65vIq=
B8GK3DA-2BCJHE92jiQLmyYgoffJUbTHvbV0d7eCOHt style=3D"-webkit-text-size-adju=
st:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decorat=
ion:underline;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img cla=
ss=3D"adapt-img" src=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du0=
01.QYAJQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkRnTTmYtIMVzGNTKgGi8UXDagUeZd5S6YqckqW=
jm1Tw7jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoRe304perj4FSk33toNFHEh8icGNAIq-2FX6GX=
B-2B230iEoKXrjLY9TuzXC3-2By0mWI0XNTijcREHlSot-2FkwVJR4qGla8O7QOn6Geekz3hRhd=
RQ-3D-3D11IU_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2Bm=
QjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnH=
MgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo40=
9wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4V=
ocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNM=
ViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsM=
s4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVot=
pWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4o=
lAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0=
k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FN=
alo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJ=
dIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34=
yugTysZP4Vxqh4K9MsDwZPll-2BamsnUfgbJB0AL4BruP7xGsfJpwhMg8bz-2BWvkzmZhcveXT4=
0KDFpQkxa-2BW6ztlMR6-2Fxsp12mybW2htiR1phSZjjtHhOucIeA4Qq1eGkBxzcGjSWVUAAJlN=
0GSJ9Q2XiA3vcbk-2F3RzZghabs-2BR-2ByY-2FcYtfI6qXA-2B5zTcZN-2FfFPiSmvJMcdWHTX=
ttAZS-2FWoDHCemVqaiyo-2FfJAf4omqnpOnTkapzDKG8RC8GR-2FGgC alt=3D"" style=3D"=
display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-=
mode:bicubic" width=3D"600"/></a></td></tr> <tr style=3D"border-collapse:co=
llapse"><td align=3D"center" style=3D"padding:0;Margin:0;font-size:0px"><im=
g class=3D"adapt-img" src=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=
=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwssdeXdMntYfkRnTTmYtIMVzGNTKgGi8UXDagUeZd5S6Y=
qckqWjm1Tw7jfk1cqfg2FqEaaaifjad2dhmOhzQrwkoRe304perj4FSk33toNFHEh8icGNAIq-2=
FX6GXB-2B230iEoKXrjLY9TuzXC3-2By0mWI0JgyZl1RhMLfQ7UZvI9XGmOf2fPi3YvkFGxt8s0=
KpXyw-3D-3DXs23_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-=
2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGe=
snHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngG=
o409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYp=
U4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0t=
BNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9B=
dsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMB=
VotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYk=
u4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2=
FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-=
2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL=
3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUV=
U34yugTysZP4Vxqh4K9MsDwVIt-2FwpZwfqrLCxXmhBZOgjxnOetrQagIdyG5l-2B3j2CJJy7-2=
BwAKK49FnST5MLI6fA8hQi0-2BgwngEUGeVoqQ2cDLnd1KRc0Tcq8dH5uXT6VyC5A2DCNdu8D8B=
CFGuTklFGNGfD6ETZxRarn7xXdce94ScJFie7pneT5C-2BZzeQQn1hIS7Xei06bKndgHAeBO1T5=
F0A5iOUHQ0l-2FMGsEcp3v1AackanuZhT298bpC19MUQN alt=3D"" style=3D"display:blo=
ck;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubi=
c" width=3D"600"/></td></tr></tbody></table></td></tr></tbody></table></td>=
</tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></=
div><div style=3D"position:absolute;left:-9999px;top:-9999px;margin:0px"></=
div><div style=3D"position:absolute;left:-9999px;top:-9999px;margin:0px;pad=
ding:0px;border:0px none;width:1px"></div></body></html>
--b14ac2ee0bc61aca5e46039d5fe228e8500a89e5e220356fd2edc062d849
Content-Transfer-Encoding: quoted-printable
Content-Type: text/html; charset=utf-8
Mime-Version: 1.0

<!--=E2=84=A2--><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//=
EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns:o=
=3D"urn:schemas-microsoft-com:office:office" xmlns=3D"http://www.w3.org/199=
9/xhtml" lang=3D"und" style=3D"padding:0;Margin:0"><head><meta http-equiv=
=3D"Content-Type" content=3D"text/html; charset=3DUTF-8"/><meta charset=3D"=
UTF-8"/><meta content=3D"width=3Ddevice-width, initial-scale=3D1" name=3D"v=
iewport"/><meta name=3D"x-apple-disable-message-reformatting"/><meta http-e=
quiv=3D"X-UA-Compatible" content=3D"IE=3Dedge"/><meta content=3D"telephone=
=3Dno" name=3D"format-detection"/><title></title> <!--[if (mso 16)]><style =
type=3D"text/css">a{text-decoration:none} </style><![endif]--><!--[if gte m=
so 9]><style>sup{font-size:100% !important}</style><![endif]--><!--[if gte =
mso 9]><style>sup{font-size:100% !important}</style><![endif]--><!--[if gte=
 mso 9]><style>sup{font-size:100% !important}</style><![endif]--><!--[if gt=
e mso 9]><style>sup{font-size:100% !important}</style><![endif]--><!--[if g=
te mso 9]><style>sup { font-size: 100% !important; }</style><![endif]--><st=
yle type=3D"text/css">#outlook a { padding:0;}.ExternalClass { width:100%;}=
.ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font,=
 .ExternalClass td, .ExternalClass div { line-height:100%;}.es-button { mso=
-style-priority:100!important; text-decoration:none!important;}a[x-apple-da=
ta-detectors] { color:inherit!important; text-decoration:none!important; fo=
nt-size:inherit!important; font-family:inherit!important; font-weight:inher=
it!important; line-height:inherit!important;}.es-desk-hidden { display:none=
; float:left; overflow:hidden; width:0; max-height:0; line-height:0; mso-hi=
de:all;}@media only screen and (max-width:600px) {p, ul li, ol li, a { line=
-height:150%!important } h1, h2, h3, h1 a, h2 a, h3 a { line-height:120%!im=
portant } h1 { font-size:30px!important; text-align:center } h2 { font-size=
:26px!important; text-align:center } h3 { font-size:20px!important; text-al=
ign:center } .es-header-body h1 a, .es-content-body h1 a, .es-footer-body h=
1 a { font-size:30px!important } .es-header-body h2 a, .es-content-body h2 =
a, .es-footer-body h2 a { font-size:26px!important } .es-header-body h3 a, =
.es-content-body h3 a, .es-footer-body h3 a { font-size:20px!important } .e=
s-menu td a { font-size:13px!important } .es-header-body p, .es-header-body=
 ul li, .es-header-body ol li, .es-header-body a { font-size:16px!important=
 } .es-content-body p, .es-content-body ul li, .es-content-body ol li, .es-=
content-body a { font-size:16px!important } .es-footer-body p, .es-footer-b=
ody ul li, .es-footer-body ol li, .es-footer-body a { font-size:16px!import=
ant } .es-infoblock p, .es-infoblock ul li, .es-infoblock ol li, .es-infobl=
ock a { font-size:12px!important } *[class=3D"gmail-fix"] { display:none!im=
portant } .es-m-txt-c, .es-m-txt-c h1, .es-m-txt-c h2, .es-m-txt-c h3 { tex=
t-align:center!important } .es-m-txt-r, .es-m-txt-r h1, .es-m-txt-r h2, .es=
-m-txt-r h3 { text-align:right!important } .es-m-txt-l, .es-m-txt-l h1, .es=
-m-txt-l h2, .es-m-txt-l h3 { text-align:left!important } .es-m-txt-r img, =
.es-m-txt-c img, .es-m-txt-l img { display:inline!important } .es-button-bo=
rder { display:block!important } a.es-button, button.es-button { font-size:=
16px!important; display:block!important; padding-left:0px!important; paddin=
g-right:0px!important } .es-btn-fw { border-width:10px 0px!important; text-=
align:center!important } .es-adaptive table, .es-btn-fw, .es-btn-fw-brdr, .=
es-left, .es-right { width:100%!important } .ext-product-button, .ext-produ=
ct-price p, .ext-product-original-price p { width:100%!important } .ext-pro=
duct-button a { max-width:100%!important } .ext-product-name.ins-vertical p=
 { height:90px!important; overflow:hidden!important; word-break:break-all!i=
mportant; font-size:12px!important; line-height:150%!important } .ext-produ=
ct-name.ins-vertical { height:100px!important } .ext-product-name p { heigh=
t:unset!important; width:100%!important; overflow:hidden!important; font-si=
ze:16px!important; line-height:150%!important } .ext-product-name { height:=
unset!important } .ext-product-price.ins-vertical p { overflow:hidden!impor=
tant; word-break:break-all!important; height:36px!important; font-size:12px=
!important; line-height:150%!important } .ext-product-price.ins-vertical { =
height:56px!important } .ext-product-original-price.ins-vertical p { overfl=
ow:hidden!important; word-break:break-all!important; height:36px!important;=
 font-size:12px!important; line-height:150%!important } .ext-product-origin=
al-price.ins-vertical { height:56px!important } .ext-ins-attr.ins-vertical =
p { overflow:hidden!important; word-break:break-all!important; height:54px!=
important; font-size:12px!important; line-height:150%!important; width:100%=
!important } .ext-ins-attr.ins-vertical { height:74px!important } .ext-prod=
uct-button a.ins-vertical { word-break:break-all!important; font-size:12px!=
important } .ext-product-image.ins-vertical { height:unset!important } td.e=
sdev-mso-td.ins-vertical { vertical-align:bottom!important } .es-content ta=
ble, .es-header table, .es-footer table, .es-content, .es-footer, .es-heade=
r { width:100%!important; max-width:600px!important } .es-adapt-td { displa=
y:block!important; width:100%!important } .adapt-img { width:100%!important=
; height:auto!important } .es-m-p0 { padding:0!important } .es-m-p0r { padd=
ing-right:0!important } .es-m-p0l { padding-left:0!important } .es-m-p0t { =
padding-top:0!important } .es-m-p0b { padding-bottom:0!important } .es-m-p2=
0b { padding-bottom:20px!important } .es-mobile-hidden, .es-hidden { displa=
y:none!important } .es-desk-hidden { display:table-row!important; width:aut=
o!important; overflow:visible!important; float:none!important; max-height:i=
nherit!important; line-height:inherit!important } .es-desk-menu-hidden { di=
splay:table-cell!important } table.es-table-not-adapt, .esd-block-html tabl=
e { width:auto!important } table.es-social { display:inline-block!important=
 } table.es-social td { display:inline-block!important } .h-auto { height:a=
uto!important } .es-m-p5 { padding:5px!important } .es-m-p5t { padding-top:=
5px!important } .es-m-p5b { padding-bottom:5px!important } .es-m-p5r { padd=
ing-right:5px!important } .es-m-p5l { padding-left:5px!important } .es-m-p1=
0 { padding:10px!important } .es-m-p10t { padding-top:10px!important } .es-=
m-p10b { padding-bottom:10px!important } .es-m-p10r { padding-right:10px!im=
portant } .es-m-p10l { padding-left:10px!important } .es-m-p15 { padding:15=
px!important } .es-m-p15t { padding-top:15px!important } .es-m-p15b { paddi=
ng-bottom:15px!important } .es-m-p15r { padding-right:15px!important } .es-=
m-p15l { padding-left:15px!important } .es-m-p20 { padding:20px!important }=
 .es-m-p20t { padding-top:20px!important } .es-m-p20r { padding-right:20px!=
important } .es-m-p20l { padding-left:20px!important } .es-m-p25 { padding:=
25px!important } .es-m-p25t { padding-top:25px!important } .es-m-p25b { pad=
ding-bottom:25px!important } .es-m-p25r { padding-right:25px!important } .e=
s-m-p25l { padding-left:25px!important } .es-m-p30 { padding:30px!important=
 } .es-m-p30t { padding-top:30px!important } .es-m-p30b { padding-bottom:30=
px!important } .es-m-p30r { padding-right:30px!important } .es-m-p30l { pad=
ding-left:30px!important } .es-m-p35 { padding:35px!important } .es-m-p35t =
{ padding-top:35px!important } .es-m-p35b { padding-bottom:35px!important }=
 .es-m-p35r { padding-right:35px!important } .es-m-p35l { padding-left:35px=
!important } .es-m-p40 { padding:40px!important } .es-m-p40t { padding-top:=
40px!important } .es-m-p40b { padding-bottom:40px!important } .es-m-p40r { =
padding-right:40px!important } .es-m-p40l { padding-left:40px!important } }=
@media screen and (max-width:384px) {.mail-message-content { width:414px!im=
portant } }</style> <!--[if gte mso 9]> <xml> <o:OfficeDocumentSettings> <o=
:AllowPNG></o:AllowPNG> <o:PixelsPerInch>96</o:PixelsPerInch> </o:OfficeDoc=
umentSettings> </xml> <![endif]--></head> <body><span style=3D"display:none=
 !important; visibility:hidden; mso-hide:all; font-size:1px; color:#ffffff;=
 line-height:1px; max-height:0px; max-width:0px; opacity:0; overflow:hidden=
;">TH=C3=94NG B=C3=81O QUAN TR=E1=BB=8CNG: v/v Kh=C3=A1ch h=C3=A0ng c=E1=BA=
=A7n th=E1=BB=B1c hi=E1=BB=87n sinh tr=E1=BA=AFc h=E1=BB=8Dc</span>
<div class=3D"es-wrapper-color" lang=3D"und" style=3D"background-color:#F6F=
6F6"><!--[if gte mso 9]> <v:background xmlns:v=3D"urn:schemas-microsoft-com=
:vml" fill=3D"t"> <v:fill type=3D"tile" color=3D"#f6f6f6"></v:fill> </v:bac=
kground> <![endif]--><table class=3D"es-wrapper" width=3D"100%" cellspacing=
=3D"0" cellpadding=3D"0" role=3D"none" style=3D"mso-table-lspace:0pt;mso-ta=
ble-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin=
:0;width:100%;height:100%;background-repeat:repeat;background-position:cent=
er top;background-color:#F6F6F6"><tbody><tr style=3D"border-collapse:collap=
se"><td valign=3D"top" style=3D"padding:0;Margin:0"><table class=3D"es-cont=
ent" cellspacing=3D"0" cellpadding=3D"0" align=3D"center" role=3D"none" sty=
le=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;bo=
rder-spacing:0px;table-layout:fixed !important;width:100%"><tbody><tr style=
=3D"border-collapse:collapse"><td align=3D"center" bgcolor=3D"#ffffff" styl=
e=3D"padding:0;Margin:0;background-color:#ffffff"><table class=3D"es-conten=
t-body" cellspacing=3D"0" cellpadding=3D"0" bgcolor=3D"#ffffff" align=3D"ce=
nter" role=3D"none" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;bord=
er-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600p=
x"><tbody><tr style=3D"border-collapse:collapse"><td align=3D"left" bgcolor=
=3D"#F6F6F6" style=3D"padding:10px;Margin:0;background-color:#f6f6f6"><tabl=
e cellspacing=3D"0" cellpadding=3D"0" width=3D"100%" role=3D"none" style=3D=
"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-=
spacing:0px"><tbody><tr style=3D"border-collapse:collapse"><td valign=3D"to=
p" align=3D"center" style=3D"padding:0;Margin:0;width:580px"><table width=
=3D"100%" cellspacing=3D"0" cellpadding=3D"0" role=3D"presentation" style=
=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;bord=
er-spacing:0px"><tbody><tr style=3D"border-collapse:collapse"><td align=3D"=
center" style=3D"padding:0;Margin:0;font-size:0px"><img class=3D"adapt-img"=
 src=3D"https://email-static.useinsider.com/f940abcdc21d4566ac97b97fb4e8650=
f/lib/pluginId_f940abcdc21d4566ac97b97fb4e8650f_acb_images/anh_banner_bwOBu=
vEWGIXtH38o.png" alt=3D"" style=3D"display:block;border:0;outline:none;text=
-decoration:none;-ms-interpolation-mode:bicubic" width=3D"580"/></td> </tr>=
</tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></=
tr></tbody></table> <table class=3D"es-content" cellspacing=3D"0" cellpaddi=
ng=3D"0" align=3D"center" role=3D"none" style=3D"mso-table-lspace:0pt;mso-t=
able-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fi=
xed !important;width:100%"><tbody><tr style=3D"border-collapse:collapse"><t=
d align=3D"center" bgcolor=3D"#ffffff" style=3D"padding:0;Margin:0;backgrou=
nd-color:#ffffff"><table class=3D"es-content-body" cellspacing=3D"0" cellpa=
dding=3D"0" bgcolor=3D"#ffffff" align=3D"center" role=3D"none" style=3D"mso=
-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spac=
ing:0px;background-color:#FFFFFF;width:600px"><tbody><tr style=3D"border-co=
llapse:collapse"><td align=3D"left" bgcolor=3D"#F6F6F6" style=3D"padding:0;=
Margin:0;padding-left:20px;padding-right:20px;background-color:#f6f6f6"><ta=
ble cellpadding=3D"0" cellspacing=3D"0" width=3D"100%" role=3D"none" style=
=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;bord=
er-spacing:0px"><tbody><tr style=3D"border-collapse:collapse"><td align=3D"=
center" valign=3D"top" style=3D"padding:0;Margin:0;width:560px"><table cell=
padding=3D"0" cellspacing=3D"0" width=3D"100%" role=3D"presentation" style=
=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;bord=
er-spacing:0px"><tbody><tr style=3D"border-collapse:collapse"><td align=3D"=
left" class=3D"es-m-txt-l" bgcolor=3D"#F6F6F6" style=3D"padding:0;Margin:0;=
padding-left:20px;padding-right:20px"><p style=3D"Margin:0;-webkit-text-siz=
e-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-f=
amily:arial, 'helvetica neue', helvetica, sans-serif;line-height:24px;color=
:#001e98;font-size:16px"><strong>K=C3=ADnh g=E1=BB=ADi: Qu=C3=BD kh=C3=A1ch=
 h=C3=A0ng=C2=A0</strong></p> <p style=3D"Margin:0;-webkit-text-size-adjust=
:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:ar=
ial, 'helvetica neue', helvetica, sans-serif;line-height:24px;color:#001e98=
;font-size:16px"><br/></p><p style=3D"Margin:0;-webkit-text-size-adjust:non=
e;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial,=
 'helvetica neue', helvetica, sans-serif;line-height:24px;color:#001e98;fon=
t-size:16px">Ng=C3=A2n h=C3=A0ng TMCP =C3=81 Ch=C3=A2u (ACB) th=C3=B4ng b=
=C3=A1o =C4=91=E1=BA=BFn Qu=C3=BD kh=C3=A1ch v=E1=BB=81 vi=E1=BB=87c Qu=C3=
=BD kh=C3=A1ch h=C3=A0ng ch=C6=B0a <strong>th=E1=BB=B1c hi=E1=BB=87n Sinh t=
r=E1=BA=AFc h=E1=BB=8Dc</strong>, =C4=91=E1=BB=83 kh=C3=B4ng b=E1=BB=8B gi=
=C3=A1n =C4=91o=E1=BA=A1n giao d=E1=BB=8Bch t=C3=A0i kho=E1=BA=A3n thanh to=
=C3=A1n, giao d=E1=BB=8Bch th=E1=BA=BB t=E1=BB=AB ng=C3=A0y 01.01.2025, Qu=
=C3=BD kh=C3=A1ch vui l=C3=B2ng th=E1=BB=B1c hi=E1=BB=87n c=C3=A1c b=C6=B0=
=E1=BB=9Bc sau:</p></td></tr></tbody></table></td></tr></tbody></table></td=
></tr> <tr style=3D"border-collapse:collapse"><td align=3D"left" bgcolor=3D=
"#F6F6F6" style=3D"padding:0;Margin:0;padding-left:20px;padding-right:20px;=
background-color:#f6f6f6"><table cellpadding=3D"0" cellspacing=3D"0" width=
=3D"100%" role=3D"none" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;=
border-collapse:collapse;border-spacing:0px"><tbody><tr style=3D"border-col=
lapse:collapse"><td align=3D"center" valign=3D"top" style=3D"padding:0;Marg=
in:0;width:560px"><table cellpadding=3D"0" cellspacing=3D"0" width=3D"100%"=
 role=3D"presentation" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;b=
order-collapse:collapse;border-spacing:0px"><tbody><tr style=3D"border-coll=
apse:collapse"><td align=3D"center" style=3D"padding:0;Margin:0;font-size:0=
px"><img class=3D"adapt-img" src=3D"https://email-static.useinsider.com/f94=
0abcdc21d4566ac97b97fb4e8650f/lib/pluginId_f940abcdc21d4566ac97b97fb4e8650f=
_acb_images/anh_2_94bsk7uRQstonBC7.png" alt=3D"" style=3D"display:block;bor=
der:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic" wid=
th=3D"560"/></td> </tr><tr style=3D"border-collapse:collapse"><td align=3D"=
left" class=3D"es-m-txt-l" bgcolor=3D"#F6F6F6" style=3D"padding:0;Margin:0;=
padding-left:20px;padding-right:20px"><p style=3D"Margin:0;-webkit-text-siz=
e-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-f=
amily:arial, 'helvetica neue', helvetica, sans-serif;line-height:24px;color=
:#293689;font-size:16px">Vui l=C3=B2ng b=E1=BB=8F qua th=C3=B4ng b=C3=A1o n=
=C3=A0y n=E1=BA=BFu Qu=C3=BD kh=C3=A1ch =C4=91=C3=A3 th=E1=BB=B1c hi=E1=BB=
=87n Sinh tr=E1=BA=AFc h=E1=BB=8Dc<br/></p><p style=3D"Margin:0;-webkit-tex=
t-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;f=
ont-family:arial, 'helvetica neue', helvetica, sans-serif;line-height:24px;=
color:#293689;font-size:16px"><br/>Tr=C3=A2n tr=E1=BB=8Dng,=C2=A0 =C2=A0 =
=C2=A0</p></td></tr> <tr style=3D"border-collapse:collapse"><td align=3D"ce=
nter" style=3D"padding:0;Margin:0;padding-bottom:10px;font-size:0px"><a tar=
get=3D"_blank" href=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du00=
1.QYAJQ2tQWI1Dgd6j-2FSrkwo07iou63cwsWyQfBw3dWt0H9oR1nNj6NwMBk-2F5-2BPlo1VeS=
ljlQZqv0QN6DAQEc99IU71nMX9-2BjK-2F5s5ZB8yLMQoV3TkApYAQJe6c1DiEPA0rqRlQ6JxtH=
lwTZxMcUvRtT-2FONN3UX4ywam2eBnLc7pPeY-2BcXi2hlEru90W1zLChVqxW4fgPaHYvl1zhxJ=
tgJQIDVdncfu-2FRgav3R-2F629YPvdks2KIjde1ILNFqMWAoUaujSFrtdxZyVF6bgySTRryrhC=
eaBrEnRk5CEv1mrA9wNGB8-2BdLfRsqxRZXHt9i7K01Aojudeu0QbJc5oeyuQCqfqMq96RXy13a=
BzbzujimZ89uMDTM46uQPEPovya97kzYQuOzKk0ivuqAMBzesamWY59recaXC-2FjzlRZSh5Jq8=
ozSlJ-2FWXpuv-2BhSYZwwN2sbOrj8_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIAR=
gQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfEC=
tjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoD=
ZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7=
HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurL=
bUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQf=
WnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSP=
ZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0q=
ILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B=
3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9ta=
E4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6=
lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwR=
qEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwe8kUQvOrJmQNMDEpq-2BJhEWeaKATQTbPKIh1=
oBx-2Fc-2FZFKg3kz1ixCmEXwOiCTuOpL0Gbe4ocDuuJC-2FBen7unGDhuomfS5hezYhwCExKjN=
0AXQiyydWhLxHNc8xzyd8SNTdfkIT6lpJtzOp6V3NtC092ZAHPWe-2B8WQC9YklmCMgx4U1bWjC=
MFhfV1A-2BOV-2Bs2GjwJIg93ULnyfmBW3Pj7n9t3Zhu8zwF0jZEg-2FgLWmjh4b" style=3D"=
-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rul=
e:exactly;text-decoration:underline;color:#333333;font-size:14px" class=3D"=
ins-vib-link"><img class=3D"adapt-img" src=3D"https://email-static.useinsid=
er.com/f940abcdc21d4566ac97b97fb4e8650f/lib/pluginId_f940abcdc21d4566ac97b9=
7fb4e8650f_acb_images/button.png" alt=3D"" style=3D"display:block;border:0;=
outline:none;text-decoration:none;-ms-interpolation-mode:bicubic" width=3D"=
560"/></a></td></tr></tbody></table></td></tr></tbody></table></td></tr></t=
body></table></td></tr></tbody></table> <table cellpadding=3D"0" cellspacin=
g=3D"0" class=3D"es-footer" align=3D"center" role=3D"none" style=3D"mso-tab=
le-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:=
0px;table-layout:fixed !important;width:100%;background-color:transparent;b=
ackground-repeat:repeat;background-position:center top"><tbody><tr style=3D=
"border-collapse:collapse"><td align=3D"center" bgcolor=3D"#ffffff" style=
=3D"padding:0;Margin:0;background-color:#ffffff"><table class=3D"es-footer-=
body" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:co=
llapse;border-spacing:0px;background-color:#002395;width:600px" cellspacing=
=3D"0" cellpadding=3D"0" align=3D"center" bgcolor=3D"#002395" role=3D"none"=
><tbody><tr style=3D"border-collapse:collapse"><td align=3D"left" style=3D"=
padding:0;Margin:0"><table cellspacing=3D"0" cellpadding=3D"0" width=3D"100=
%" role=3D"none" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border-=
collapse:collapse;border-spacing:0px"><tbody><tr style=3D"border-collapse:c=
ollapse"><td valign=3D"top" align=3D"center" style=3D"padding:0;Margin:0;wi=
dth:600px"><table width=3D"100%" cellspacing=3D"0" cellpadding=3D"0" role=
=3D"presentation" style=3D"mso-table-lspace:0pt;mso-table-rspace:0pt;border=
-collapse:collapse;border-spacing:0px"><tbody><tr style=3D"border-collapse:=
collapse"><td align=3D"center" style=3D"padding:0;Margin:0;font-size:0px"><=
img src=3D"https://email-static.useinsider.com/f940abcdc21d4566ac97b97fb4e8=
650f/lib/pluginId_f940abcdc21d4566ac97b97fb4e8650f_acb_images/ngan_hang_a_c=
hau.png" alt=3D"" style=3D"display:block;border:0;outline:none;text-decorat=
ion:none;-ms-interpolation-mode:bicubic" class=3D"adapt-img" width=3D"600"/=
></td> </tr><tr style=3D"border-collapse:collapse"><td align=3D"center" sty=
le=3D"padding:0;Margin:0;font-size:0px;background-color:#002395" bgcolor=3D=
"#002395"><table cellpadding=3D"0" cellspacing=3D"0" class=3D"es-table-not-=
adapt es-social" role=3D"presentation" style=3D"mso-table-lspace:0pt;mso-ta=
ble-rspace:0pt;border-collapse:collapse;border-spacing:0px"><tbody><tr styl=
e=3D"border-collapse:collapse"><td align=3D"center" valign=3D"top" style=3D=
"padding:0;Margin:0;padding-right:15px"><a target=3D"_blank" href=3D"https:=
//u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwm4s6=
OMGFY4w1y34rLJ5LC3nnGidLTeDKF7niTnowhspuAY7V-2Fwzh6wGYRmryimMXXAYtVr-2FnKoN=
cpOKtyiXSJiTihPf5mDWrFySvsCMCb-2BGBCaWSBlPuwicih3RrFWWvgR4cU0uv97THKav-2BGV=
pNF-2FycFXg5Kxl9h9HL3VACCVbtrVFZZPoBYicD2YM2HUni1GQbYG1VJMdu4WdZldQG2kBrUfD=
OxOxwya9-2FgVC9VP8dSwflgIwE24t7r4FKdynF7fdoDpQNM-2F3DANpe7WAc5W1wishh9zRs23=
yACE1wADSxUeh_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2B=
mQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesn=
HMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo4=
09wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4=
VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBN=
MViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9Bds=
Ms4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVo=
tpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4=
olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK=
0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2F=
Nalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3v=
JdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU3=
4yugTysZP4Vxqh4K9MsDwWsYVWVVNn1dFQeAVJBPzDZQmhZxEQKOYlwWVunOK5WWCWdKZE9JUwU=
Ci0Sjm7IGu0ZqfUyE7DzLf55P-2FNR0Q81XS-2BzWPVp3ttng5hoTmFDjGl0zuThyuiCHjRlj37=
9db0BNagJuVGUg-2BmCKQEoWBnvjOLerT-2FUFJW7qNNIw1IKaahpovfa-2FeBg4n4PzD5SPQiW=
ETCVKXMmULZ5RwAOuO-2BM9W91fyqhmAlNNFSnsDYhp" style=3D"-webkit-text-size-adj=
ust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decora=
tion:underline;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img ti=
tle=3D"Facebook" src=3D"https://web-image.useinsider.com/email-template/fac=
ebook.png" alt=3D"Facebook" width=3D"32" width=3D"32" style=3D"display:bloc=
k;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic=
"/></a></td> <td align=3D"center" valign=3D"top" style=3D"padding:0;Margin:=
0;padding-right:15px"><a target=3D"_blank" href=3D"https://u45836307.ct.sen=
dgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwrs17boCYLVoZcoIP38kDFj=
OkDV9wAj-2BU4aX33iOziU5iAtqBonFb2UJl8f0vOLXHVQgrn-2BNxOoRz4wY2Aan1nrYpqV-2F=
M16tvL0D31Tor6IkqCh-2Fk9bDE3d-2FuPdaPZzIr-2F0IgfbzjyzQTWXNPOebolCV5HglfgigE=
jL0WhQYAhL6dVYO3oPnbWmLoVq1KL5PvQUG7yRcfOIBRpAVjbEgZn1NXAzIApTUL2hwnNqiw-2F=
X-2FbdOHSJusQYG2PMUNPnRkoyhxZmNAmFmkj1eyJc9PAG8R2chj858hduQxY8RF6NA7C3bS1XQ=
xlYqcMiu4-2B8K1vQ-3D-3DrN_Y_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQa=
tAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs=
6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkp=
qSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3=
m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUW=
BgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWno=
NsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkc=
QyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILS=
IfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3Hy=
QAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4M=
Nhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXg=
aGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEX=
l2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwesuz-2F2z9QV2NV3Y-2BTbzgm42FdOYeIUxO0giM=
ZLeRHHDgsx-2FHu-2BhL77zz9fupkRi-2BB2jomGCNouWKHwLQ7749E0bcU28JNdTysPn0SyBTh=
A9kDfObTuRrAdPA9IBwqc3MhBw045Aj86ncqe4ux7uovfpS0B55UzBAWtmyWxgOOHVJ2KAgNdy-=
2B70DktdXDeSuvc3WmgNAU3eGTe2web1Y5sIzo-2F2hzj4BDJ-2FFR5mj8NdZ" style=3D"-we=
bkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:e=
xactly;text-decoration:underline;color:#FFFFFF;font-size:14px" class=3D"ins=
-vib-link"><img title=3D"Tiktok" src=3D"https://email-static.useinsider.com=
/f940abcdc21d4566ac97b97fb4e8650f/lib/pluginId_f940abcdc21d4566ac97b97fb4e8=
650f_acbuat_images/asset_1_95l6eO2JANYXFI5p.png" alt=3D"Tiktok" width=3D"32=
" width=3D"32" style=3D"display:block;border:0;outline:none;text-decoration=
:none;-ms-interpolation-mode:bicubic"/></a></td> <td align=3D"center" valig=
n=3D"top" style=3D"padding:0;Margin:0;padding-right:15px"><a target=3D"_bla=
nk" href=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQW=
I1Dgd6j-2FSrkwpLRSnVe8SVWaECdG4Y1iu7xlxZPGooUqXHNDBNdowF13-2FAFVb-2FH-2BLDY=
DihF2JbUW2uiDWRM4uFNmbunZIXy5eWMrris5Wgz1WSF12Qeb37YwCiP8JcHDKv8puswyD7Cgc5=
3F-2FECc62WfuXEYWYvQX6HW-2BUapLLXYemuSISMrhfBKTUUZIpLtXitj0UNXHE0Poi6S8hZuY=
iSmta4hMNQwTZi0isCbonrHf-2BhImP8idoxa8JlLGPGUKdiJCOUJUOK-2B89VOtGdJTfqg2M8D=
Zts9dY0j7qHx2EBXYgpxRv0ORmgchEe_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIA=
RgQatAoj7gwZ-2B-2BmQjbvSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfE=
Ctjs6w26zYyPozGesnHMgN5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEho=
DZkpqSDSc8CzvngGo409wc1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M=
7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRur=
LbUWBgI3DKqgFG0tBNMViXtK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQ=
fWnoNsQyvO4RFb9BdsMs4lOSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JS=
PZkcQyIA6P9haLMBVotpWMFVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0=
qILSIfhqHrGDEmYku4olAI3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2=
B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9t=
aE4MNhb-2FfbC5L-2FNalo1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf=
6lXgaGw0ugTAIwgL3vJdIVAypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqw=
RqEXl2l6YjvBDdUVU34yugTysZP4Vxqh4K9MsDwcykZ7Q81em6t0akAgJHEq5IqphWoX6gHC8gK=
NcuWyhodbdQSBdAF3vM4GwDdRN5ZS30X1gbeFZ7nkuwGocIds8XVXkDMFZddHqIdmXitLi0LZRf=
eREw-2FWnF0n8CZVmh-2FNpsV9COXp9QV-2FA8JjEc0BvZeZI45bsjUf8-2FqQHSid-2B3RBhhU=
lcMBSl-2Fu-2BMb6sKFXCxG623Kxk00cCR9G0DbOgmcTdkAiKKCEZxXX5DyoR73" style=3D"-=
webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule=
:exactly;text-decoration:underline;color:#FFFFFF;font-size:14px" class=3D"i=
ns-vib-link"><img title=3D"Zalo" src=3D"https://email-static.useinsider.com=
/f940abcdc21d4566ac97b97fb4e8650f/lib/pluginId_f940abcdc21d4566ac97b97fb4e8=
650f_acbuat_images/asset_2.png" alt=3D"Zalo" width=3D"33" width=3D"32" styl=
e=3D"display:block;border:0;outline:none;text-decoration:none;-ms-interpola=
tion-mode:bicubic"/></a></td> <td align=3D"center" valign=3D"top" style=3D"=
padding:0;Margin:0;padding-right:15px"><a target=3D"_blank" href=3D"https:/=
/u45836307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwuNi-2=
F2tr8kE3phSP6yKXt4e1VMvG7Mn4dwhZ24rpqWpll6XJU3VDNqDwx8jFhiry83p-2Fwf5bnuzlP=
KwpCL-2FTFjfa3Gck4Tg-2B-2BG-2FUCXVmnfJURPRseE6oUGq4aYWSPAUOfSX2QVNx6sPE5eWC=
k63fUw-2BbaT92LS3cg1Ocr-2BdUUhD9e5YjKCtBK-2BKIH-2BYtTpx9Od-2FPfigHdBhorypuQ=
XkZ28vgw3UAgJ1B0GnJlYxJmHkdlUzXDbtfm1jLjO2bs-2BbkJZe9u6i-2B7XjCTAciyjyXV-2B=
ry1ZmZM5isXmjSJVCKeJR7TnTjqSiUD6WBI-2BCg5c9Rk-2BDaR-2FlBSGxFlaMC9D4EH2U-3Dn=
ULW_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9=
DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MID=
J-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5=
vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2F=
q2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BN=
SaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQC=
B2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9R=
BHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJo=
RxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyL=
j4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2=
YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-=
2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4=
Vxqh4K9MsDwfFn4WeIlNm2vY-2FvafXQvnWoM8w2fPLHYpp008tTCfr7pQk047NVx6hXnZpyJ1A=
ndmu2wnmq9N63hphPhJNR3Fz-2F0jsK9qCwI3-2BkOumR-2B00kW29qHkjQxpYN87oYtBOzLyrV=
JW4F90mfQGU2KM4-2B2NtpJGVvwxAxQ6m34x-2B4v66t6uBTvQHslNTg4pYv4aDO1QZ-2FNROLp=
-2FRkdUUWt8LMcXbFqJv8ql1R2BT53cc8aimK" style=3D"-webkit-text-size-adjust:no=
ne;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:u=
nderline;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img title=3D=
"YouTube" src=3D"https://email-static.useinsider.com/f940abcdc21d4566ac97b9=
7fb4e8650f/lib/pluginId_f940abcdc21d4566ac97b97fb4e8650f_acbuat_images/asse=
t_3.png" alt=3D"Yt" width=3D"32" width=3D"32" style=3D"display:block;border=
:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"/></a><=
/td> <td align=3D"center" valign=3D"top" style=3D"padding:0;Margin:0"><a ta=
rget=3D"_blank" href=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du0=
01.QYAJQ2tQWI1Dgd6j-2FSrkwmEFlESLMKGTSbQ8evuUpay-2FTzxU9cb0Pp2DbmMwJsvt3m2q=
n3SXTqaA9oxlU8Ii08LtP7nNMeB-2BNHhXPWTkAC1EmaIxahgypizEX7yaC83yfP9ImNQImYf1k=
CdrOQ0b-2BcI-2B2CzV-2FOrF3L1vd5106GihcUVb5gWYE9Tx-2BQlxMXJqk-2BkZN2-2BewWxf=
OgJ6tgUZa7FZVEaDyieOCF9N5HMp1VVYslie4omJD68WBOMaxV3zjsxOvFIwNGO6Y89EWVdOpU1=
RxtM4zcooVNuahwlQ5T26M9tRUyDp743gZyaIUNG2wZCdD3pl7Vy6fLy-2Fy8jGJg-3D-3Dc5eB=
_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSxUl9Dyp=
eQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0MIDJ-2=
BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2oO5vnV=
ZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq-2Fq2b=
83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-2BNSaY=
wU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSejQCB2q=
xKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVzX9RBHX=
4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3BhlJoRxZ=
byC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2BLyLj4s=
E9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Scij2YG1=
7lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAypFj-2Fp=
Bcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTysZP4Vxq=
h4K9MsDwT-2BZqk1NEgPrJZK20Se-2FowFUpnT-2B1CLnDyXbfxXxG-2BLYYAVUOeF5m6hxlGtp=
v9ZrCWtDjYZbKtJoIXQOqM7NvXOS3t5-2FQPzlGe18L-2FPXZTpvC2DhSZ6LC-2FLy1K6sRJDhS=
ZFUKjdmoo3VgztIS2Ug8bTvq2W9ZuwPBjRmzVKtLxZb-2BeBzQlJduD9ihQsxZqn4JG4dMX1u9h=
GarhJr7eWG48UIfDAPyysykaOBZS-2Fs7Kz4" style=3D"-webkit-text-size-adjust:non=
e;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decoration:un=
derline;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img title=3D"=
Instagram" src=3D"https://email-static.useinsider.com/f940abcdc21d4566ac97b=
97fb4e8650f/lib/pluginId_f940abcdc21d4566ac97b97fb4e8650f_acbuat_images/ass=
et_4.png" alt=3D"Ig" width=3D"32" width=3D"32" style=3D"display:block;borde=
r:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic"/></a>=
</td></tr></tbody></table></td></tr> <tr style=3D"border-collapse:collapse"=
><td align=3D"center" class=3D"es-m-p10t es-m-p10r es-m-p10l" bgcolor=3D"#0=
02395" style=3D"padding:0;Margin:0;padding-top:20px;padding-left:20px;paddi=
ng-right:20px"><p style=3D"Margin:0;-webkit-text-size-adjust:none;-ms-text-=
size-adjust:none;mso-line-height-rule:exactly;font-family:arial, 'helvetica=
 neue', helvetica, sans-serif;line-height:15px;color:#f1f1f1;font-size:10px=
">=C4=90=C3=A2y l=C3=A0 h=E1=BB=87 th=E1=BB=91ng email t=E1=BB=B1 =C4=91=E1=
=BB=99ng c=E1=BB=A7a Ng=C3=A2n h=C3=A0ng TMCP =C3=81 Ch=C3=A2u. Qu=C3=BD kh=
=C3=A1ch nh=E1=BA=ADn =C4=91=C6=B0=E1=BB=A3c email n=C3=A0y v=C3=AC Qu=C3=
=BD kh=C3=A1ch</p><p style=3D"Margin:0;-webkit-text-size-adjust:none;-ms-te=
xt-size-adjust:none;mso-line-height-rule:exactly;font-family:arial, 'helvet=
ica neue', helvetica, sans-serif;line-height:15px;color:#f1f1f1;font-size:1=
0px">ch=E1=BA=A5p thu=E1=BA=ADn =C4=91=E1=BB=83 Ng=C3=A2n h=C3=A0ng =C3=81 =
Ch=C3=A2u ACB g=E1=BB=ADi =C4=91=E1=BA=BFn cho Qu=C3=BD kh=C3=A1ch c=C3=A1c=
 th=C3=B4ng tin v=C3=A0 giao d=E1=BB=8Bch li=C3=AAn quan =C4=91=E1=BA=BFn s=
=E1=BA=A3n ph=E1=BA=A9m</p> <p style=3D"Margin:0;-webkit-text-size-adjust:n=
one;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:aria=
l, 'helvetica neue', helvetica, sans-serif;line-height:15px;color:#f1f1f1;f=
ont-size:10px">v=C3=A0 d=E1=BB=8Bch v=E1=BB=A5 c=E1=BB=A7a ACB.</p></td></t=
r><tr style=3D"border-collapse:collapse"><td align=3D"center" class=3D"unsu=
bscribe-block" bgcolor=3D"#002395" style=3D"padding:0;Margin:0"><p style=3D=
"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-=
height-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-se=
rif;line-height:15px;color:#f1f1f1;font-size:10px"><a href=3D"https://u4583=
6307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwt5HYe09Aeuk=
TXKjMWRfoX8DlAXWDK0hUqgdVYBaZGmQwTyCqJCTRrm9cH7hqP896O9iEj6Y-2B-2Bq9NVNmKkT=
TBsadYsvK8u-2Fko-2FfoeK8ab43n1hK5G09x5EzILWWzPbPidfZdu9cfDA8AhnZhE8t16-2F8-=
3DyaLK_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbvSx=
Ul9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5u0=
MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1s2=
oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNnTq=
-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXtK-=
2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lOSe=
jQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMFVz=
X9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3Bh=
lJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-2B=
LyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1Sc=
ij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVAyp=
Fj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugTys=
ZP4Vxqh4K9MsDwRGYfWguCs0Oe9NRJhwj0xvhP2tTpGDpcsr9E9itihbw08AU9A8zUMTpoH-2FH=
K5L0P9Iyj67BhY9ecTsgSeek-2BQukhcWwEXOZSmE6stGjk3iJeHXwbQulKXj9UnfOdC3l9cI0U=
mHOJu-2BIEOKx5YlzngaJ2E-2BMBWLZVoT4EXv40i0JOUgOYMj1XMEoBt2o-2B13divozc709I9=
j-2B2hZATKS94PTwjRFYW03XbplofNB0NoIW" class=3D"unsubscribe-link" target=3D"=
_blank" style=3D"-webkit-text-size-adjust:none;-ms-text-size-adjust:none;ms=
o-line-height-rule:exactly;text-decoration:underline;color:#ffffff;font-siz=
e:10px">Qu=C3=BD kh=C3=A1ch c=C3=B3 th=E1=BB=83 ng=E1=BB=ABng nh=E1=BA=ADn =
c=C3=A1c th=C3=B4ng b=C3=A1o khuy=E1=BA=BFn m=C3=A3i t=E1=BB=AB ACB b=E1=BA=
=B1ng c=C3=A1ch nh=E1=BA=A5n<strong> v=C3=A0o =C4=91=C3=A2y</strong></a> *<=
/p> <p style=3D"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust=
:none;mso-line-height-rule:exactly;font-family:arial, 'helvetica neue', hel=
vetica, sans-serif;line-height:15px;color:#f1f1f1;font-size:10px">Vui l=C3=
=B2ng kh=C3=B4ng tr=E1=BA=A3 l=E1=BB=9Di th=C6=B0 =C4=91i=E1=BB=87n t=E1=BB=
=AD n=C3=A0y</p></td></tr><tr style=3D"border-collapse:collapse"><td align=
=3D"center" class=3D"es-m-p10" bgcolor=3D"#002395" style=3D"padding:5px;Mar=
gin:0"><p style=3D"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adj=
ust:none;mso-line-height-rule:exactly;font-family:arial, 'helvetica neue', =
helvetica, sans-serif;line-height:15px;color:#f1f1f1;font-size:10px"><br/><=
/p> <p style=3D"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust=
:none;mso-line-height-rule:exactly;font-family:arial, 'helvetica neue', hel=
vetica, sans-serif;line-height:15px;color:#f1f1f1;font-size:10px"><strong>M=
=E1=BB=8Di th=C3=B4ng tin c=E1=BA=A7n h=E1=BB=97 tr=E1=BB=A3, Qu=C3=BD kh=
=C3=A1ch vui l=C3=B2ng li=C3=AAn h=E1=BB=87 t=E1=BA=A1i:<br/>Ph=C3=B2ng ch=
=C4=83m s=C3=B3c v=C3=A0 d=E1=BB=8Bch v=E1=BB=A5 kh=C3=A1ch h=C3=A0ng - Con=
tact Center: 1900 54 54 86 - (028) 38 247 247 </strong></p><p style=3D"Marg=
in:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-heigh=
t-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;l=
ine-height:15px;color:#f1f1f1;font-size:10px"><strong>ho=E1=BA=B7c 1800 577=
 775 (Mi=E1=BB=85n ph=C3=AD - d=C3=A0nh cho kh=C3=A1ch h=C3=A0ng =C6=AFu ti=
=C3=AAn)</strong></p><p style=3D"Margin:0;-webkit-text-size-adjust:none;-ms=
-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial, 'hel=
vetica neue', helvetica, sans-serif;line-height:15px;color:#f1f1f1;font-siz=
e:10px"><br/></p> <p style=3D"Margin:0;-webkit-text-size-adjust:none;-ms-te=
xt-size-adjust:none;mso-line-height-rule:exactly;font-family:arial, 'helvet=
ica neue', helvetica, sans-serif;line-height:18px;color:#f1f1f1;font-size:1=
2px"><strong>Qu=C3=A9t m=C3=A3 QR ho=E1=BA=B7c t=E1=BA=A3i =E1=BB=A9ng d=E1=
=BB=A5ng t=E1=BA=A1i</strong></p></td></tr><tr style=3D"border-collapse:col=
lapse"><td align=3D"center" style=3D"padding:0;Margin:0;font-size:0px"><a t=
arget=3D"_blank" href=3D"https://u45836307.ct.sendgrid.net/ls/click?upn=3Du=
001.QYAJQ2tQWI1Dgd6j-2FSrkwkozUADpM9Nbhn-2BW7gwOaZDsBQqSXJKBaH1c3ZK0Ar-2FMl=
WFM9YshcmMEBQx9AKcQKf-2FxFkV73uXOBL9byZ-2FQhPX7xzhN7o-2Bb1g-2F0ZmMJ6U-2FYQp=
xAHmGbX0srY-2B6IEWmC1pbNo6B2kngAEPpVvAnc72IR-2FaY8f99uYXMwz2rbwWY6ksay0nvqc=
ycaoTIwapgMVqhmscrfzc2zM5iKW-2FckKq-2ByHt2oEXaQ-2Bs8Bt-2Fozdqa35w1UEGJvC8rl=
LdM8RCwYTYZpHhfAtO44sxj6Kx0iOjHk28jHYAxUBGxApALUXDzypNZNphTYdvWYF0zj6Iso5g-=
3D-3DbOUv_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjb=
vSxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN=
5u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc=
1s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocN=
nTq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViX=
tK-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4l=
OSejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWM=
FVzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI=
3BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w=
-2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo=
1Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIV=
AypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yug=
TysZP4Vxqh4K9MsDwaGKfqGWnfcpw2vl038B716TWt3QerZyE27l1kC0Dw3seF6hMEf84wFiq-2=
BFCxSLIrozRUswmcKAHqDAbpZsgGWJPGnTyxbOBFpTwz9pLlYCJt-2B1wy4caxPtLvpNGU2UBH8=
eb2zuKwDCT-2Bczjf6kUk9micJnXgbm5TbPekSvUctoBi-2FwB-2FauxD5EWcGvNeGCDHT4MOA0=
-2BgH1zd4hf0EswagfCo-2F9yU0gYeQN9D09V2L4K" style=3D"-webkit-text-size-adjus=
t:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decorati=
on:underline;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img src=
=3D"https://email-static.useinsider.com/f940abcdc21d4566ac97b97fb4e8650f/li=
b/pluginId_f940abcdc21d4566ac97b97fb4e8650f_acb_images/anh_app_store.png" a=
lt=3D"" style=3D"display:block;border:0;outline:none;text-decoration:none;-=
ms-interpolation-mode:bicubic" class=3D"adapt-img" width=3D"600"/></a></td>=
</tr> <tr style=3D"border-collapse:collapse"><td align=3D"center" style=3D"=
padding:0;Margin:0;font-size:0px"><a target=3D"_blank" href=3D"https://u458=
36307.ct.sendgrid.net/ls/click?upn=3Du001.QYAJQ2tQWI1Dgd6j-2FSrkwqKLgtDRaI6=
99Wj9rZVVmBqAz3lQasPNMD8Nixu3hFkZyHHDdYV9oMlxYN5QWwz288o4Oc2I1M9arUalVZxXXO=
-2FbbPUf7RhBr3j9vcIfN9pVk2eVDwIM1gP32fW5MkyenrTWJJJb7lKBWg-2F5Ig-2BVkk-2Bv-=
2BOBc20tVPRNR32endoM92KRxkYjY4oJ5Zskd8Ainy4uO8FOKXTT-2FBfEEThCoO3A3fr8PvLW-=
2BE-2BD2RGUSpCDbdy2jYZlBCuSanhVRq-2FnO2KYxR0I4V0XRiJq1foq9-2BDvA3agh-2FHuAX=
4OOPvFZuC5Dvj985kRTPmfVj7rIMlYd7jxaG7XnFqv81nnmUSVy4OS7Q8-2F-2BShhFdyR61Hne=
5uBmnB5Q_XA-2BSAJ5yQ16bYvknef-2FUg5JWhPMDhhneR-2BjIARgQatAoj7gwZ-2B-2BmQjbv=
SxUl9DypeQ-2F9n0-2BOoe-2BVyjYN367wUIbw-2F0tqOeMEqqfECtjs6w26zYyPozGesnHMgN5=
u0MIDJ-2BDbKzHZN1pxH1w-2FHdFigI5m-2F15TzXJLhAAkKdEhoDZkpqSDSc8CzvngGo409wc1=
s2oO5vnVZM1gJQ-2Bqypo8NZlbWiZ0bVdZVjAnhXKLn62ubJem0M7HD3m-2BZpvk7nYpU4VocNn=
Tq-2Fq2b83kkRTycTfQEUc8Na7ln0uqdbNxewaJuisziO0kflRurLbUWBgI3DKqgFG0tBNMViXt=
K-2BNSaYwU8h5PW19Wyr3COVYkBilDbKkAGxxf3qxtwIoFUklfoQfWnoNsQyvO4RFb9BdsMs4lO=
SejQCB2qxKyckPaKFYbAQSd-2Ba21vkivO8uYxbYBQb40ayFX7JSPZkcQyIA6P9haLMBVotpWMF=
VzX9RBHX4zbvtlxEY5LNNHd034E-2FibaqpCuiycF9n18BbcpkF0qILSIfhqHrGDEmYku4olAI3=
BhlJoRxZbyC-2F1Hl20Us5554e2iWoh5BIKCIO77rlq26XNhtl-2B3HyQAbuVR9uFz-2FK0k6w-=
2BLyLj4sE9WRWRJa4qz609pS2Xob8ecxHdLnbP-2FILQRYlEzf9taE4MNhb-2FfbC5L-2FNalo1=
Scij2YG17lwbb-2FhFTkwHo7eJ8AvC9Zxe2ACLnP5hgGYO59vErf6lXgaGw0ugTAIwgL3vJdIVA=
ypFj-2FpBcg5TZn8lwqqCipfU93OGcIJho8ANifoUDljzo6zqWqwRqEXl2l6YjvBDdUVU34yugT=
ysZP4Vxqh4K9MsDwZF9-2BB02oZWSTFdRkBnMavhpl5GOMmjMrpgbEwl1n3HGlLQRxBHosZa6pF=
knQaAwuWde6pkexKsFmYQwMnT2-2FT-2BizHN1BbjK9aOL8Ikep54jz5072MFkuS6Jth97tejgj=
rzeclDGzSBQbubpIFPs8l4SiuG2A0pyyx7-2B9-2F-2BHTEZxL7QpsdG4QqhNX62GxjrGEn0a2i=
-2FakCU-2F47A7Jzpd1Rfqsz-2BNJxNbCxTbRLa5zTjT" style=3D"-webkit-text-size-ad=
just:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;text-decor=
ation:underline;color:#FFFFFF;font-size:14px" class=3D"ins-vib-link"><img c=
lass=3D"adapt-img" src=3D"https://email-static.useinsider.com/f940abcdc21d4=
566ac97b97fb4e8650f/lib/pluginId_f940abcdc21d4566ac97b97fb4e8650f_acb_image=
s/anh_google_store.png" alt=3D"" style=3D"display:block;border:0;outline:no=
ne;text-decoration:none;-ms-interpolation-mode:bicubic" width=3D"600"/></a>=
</td></tr> <tr style=3D"border-collapse:collapse"><td align=3D"center" styl=
e=3D"padding:0;Margin:0;font-size:0px"><img class=3D"adapt-img" src=3D"http=
s://email-static.useinsider.com/f940abcdc21d4566ac97b97fb4e8650f/lib/plugin=
Id_f940abcdc21d4566ac97b97fb4e8650f_acb_images/anh_logo_goc.png" alt=3D"" s=
tyle=3D"display:block;border:0;outline:none;text-decoration:none;-ms-interp=
olation-mode:bicubic" width=3D"600"/></td></tr></tbody></table></td></tr></=
tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr=
></tbody></table></div><div style=3D"position:absolute;left:-9999px;top:-99=
99px;margin:0px"></div><div style=3D"position:absolute;left:-9999px;top:-99=
99px;margin:0px;padding:0px;border:0px none;width:1px"></div><img src=3D"ht=
tps://u45836307.ct.sendgrid.net/wf/open?upn=3Du001.X-2B-2BihUB0b4TavRuHomnb=
KtCsxjpzVPDz8zXhxj3PXLxizUVUrBALdGH0AThh-2BDGCGG0bMGMQMg-2BZW-2F52HAHhTVtfV=
ufZ8Fe8b-2FmhWM4BTaMeVueOosnlJ9eA-2FO9wyH-2BBRK0COFFmif-2F1zX0Go4fNFTYONIZ4=
pu45Yiozarf9yRCRPbmde5U-2B35vtL5YsZeVrACSNhxJoMchQvjnFCl4jZPx1OVtQecu-2BDwm=
FYd6q78RezPSoOy-2FBXXJwqzP8j-2FOM-2FHvd0z4rKYVNjZilBrApsFe1r1KdtMlOB8EfnPVS=
JTee6Ql9uuHcwko-2FHCP0iUPD47Pdys4bvaAR-2B7Oyuqoc4abFWJS8Hn8k85LF-2B2fzQdJxh=
AOYw5ZQm37H8cE-2BQhSnYwJWJHrqkqR7wCWD-2FbwcGFPQ84liUNuCLNZphjB1mBe-2Fl-2Ftc=
agFdaURKdWg6cYv5AC-2BTRb98be2wvvqez-2F6XXuz3E-2BIWa11cbc86rJLPz8QAtpYbiOdc3=
tWnTalbl1p3IFw7VSL3R3mW2IYwrKisS-2FrLjdnbCXldayZIUteXAYBMNObDLeHnLvRlpO4KKi=
FkupcKo1bPE8yvb2IOs5R7hPI7Pp99xUbyZ5JzjBdAsf9OQ2B5W2J9ULt5BfiGywUQRRYY5Au6I=
fGbtIYOf-2Fvr0LJ0bvjhqOvzv9cSJstkfc7e04qM6062Rhf-2BeZYacU-2BhR6ALnhplDnAa-2=
FZ9vG46VjXvrsXF7MJ6K1IvY8AwnidUd7EWsmXBpamUNWsG583lFSxM-2FItrJMq9vLPPmYQ3Wm=
ptqpCP4mDUq34EkGDMvMBFZu7HaDIV5qOdiHv36M-2FyVkt4Yl4xsCi2gHExlzjohhB2OsaGIQF=
rmtvSiBhe-2BJIldm2TLdOJEWXi0nlKVuCCA1tFbFz-2FPpyELfyBsa8qD9suNA5hYU7OceUjEy=
79RECpWdeh2hg1-2FHjoQ1tui70b5ja9kynjSi3czhhrgUyDMO8ikyXAyT2AlLT9rIiqjIgKEax=
Lm9GvS94r0evo9dAmtWnO-2F3Oq-2FI6f12ATNVNGifv5WTtPCz29QWZfM4eP07Eck5cjY2QOWd=
l57vYcUL3fk" alt=3D"" width=3D"1" height=3D"1" border=3D"0" style=3D"height=
:1px !important;width:1px !important;border-width:0 !important;margin-top:0=
 !important;margin-bottom:0 !important;margin-right:0 !important;margin-lef=
t:0 !important;padding-top:0 !important;padding-bottom:0 !important;padding=
-right:0 !important;padding-left:0 !important;"/></body></html>
--b14ac2ee0bc61aca5e46039d5fe228e8500a89e5e220356fd2edc062d849--
