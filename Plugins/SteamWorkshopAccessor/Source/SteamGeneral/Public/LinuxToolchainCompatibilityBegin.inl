
// Helper files to allow compilation for Linux. Goes together with LinuxToolchainCompatibilityEnd

// Linux Toolchain defines R_OK which causes an issue with EResultBP::R_OK

#ifdef R_OK
#pragma push_macro("R_OK")
#undef R_OK
#define NEED_R_OK_POP
#endif

