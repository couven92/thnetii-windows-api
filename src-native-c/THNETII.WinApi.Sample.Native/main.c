#include <Windows.h>

#define SECURITY_WIN32 1
#include <sspi.h>

int main(int argc, char* argv[])
{
    ALG_ID instance;
    const int size = sizeof(instance);
    const int value = SECPKG_CRED_ATTR_CERT;

    const void* ptr = QueryContextAttributesW;

    return EXIT_SUCCESS;
}
