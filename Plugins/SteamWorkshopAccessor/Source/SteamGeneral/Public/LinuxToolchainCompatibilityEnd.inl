#pragma once

// Helper files to allow compilation for Linux. Goes together with LinuxToolchainCompatibilityBegin

#ifdef NEED_R_OK_POP
#undef NEED_R_OK_POP
#pragma pop_macro("R_OK")
#endif