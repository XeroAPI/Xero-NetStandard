#!/bin/bash

prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero_accounting.yaml --host 127.0.0.1 --port 4010 &
prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero-app-store.yaml --host 127.0.0.1 --port 4011 &
prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero_assets.yaml --host 127.0.0.1 --port 4012 &
prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero_bankfeeds.yaml --host 127.0.0.1 --port 4013 &
prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero-finance.yaml --host 127.0.0.1 --port 4014 &
prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero-payroll-uk.yaml --host 127.0.0.1 --port 4015 &
prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero-payroll-nz.yaml --host 127.0.0.1 --port 4016 &
prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero-payroll-au.yaml --host 127.0.0.1 --port 4017 &
prism mock https://raw.githubusercontent.com/XeroAPI/Xero-OpenAPI/refs/heads/$1/xero-projects.yaml --host 127.0.0.1 --port 4018