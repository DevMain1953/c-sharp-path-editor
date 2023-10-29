# Overview

This repository contains the first implementation of an algorithm for editing process memory in the virtual address space. To implement reading and writing bytes in addresses, WinAPI functions are used, which are loaded from dll libraries. The algorithm performs:
- reading bytes in process memory that are loaded from a file at the time the program is launched;
- projection of the received data onto an image with scale;
- writing new data back to process memory.